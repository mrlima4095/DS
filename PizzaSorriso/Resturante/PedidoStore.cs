using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Resturante
{
    public class RegistroPedido
    {
        public DateTime Data { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Pagamento { get; set; }
        public double Total { get; set; }
        public string Itens { get; set; }
    }

    public static class PedidoStore
    {
        private static readonly string Pasta = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "PizzariaSorriso");

        private static readonly string Arquivo = Path.Combine(Pasta, "pedidos.dat");

        public static string CaminhoArquivo
        {
            get { return Arquivo; }
        }

        public static void Salvar(RegistroPedido pedido)
        {
            Directory.CreateDirectory(Pasta);
            Esconder(Pasta);

            File.AppendAllText(Arquivo, Formatar(pedido) + Environment.NewLine, Encoding.UTF8);
            Esconder(Arquivo);
        }

        public static List<RegistroPedido> Carregar()
        {
            List<RegistroPedido> lista = new List<RegistroPedido>();

            if (!File.Exists(Arquivo))
            {
                return lista;
            }

            foreach (string linha in File.ReadAllLines(Arquivo, Encoding.UTF8))
            {
                RegistroPedido pedido = Interpretar(linha);

                if (pedido != null)
                {
                    lista.Add(pedido);
                }
            }

            return lista;
        }

        public static void Remover(int indice)
        {
            List<RegistroPedido> pedidos = Carregar();

            if (indice < 0 || indice >= pedidos.Count)
            {
                return;
            }

            pedidos.RemoveAt(indice);
            SalvarTodos(pedidos);
        }

        public static void SalvarTodos(List<RegistroPedido> pedidos)
        {
            Directory.CreateDirectory(Pasta);
            Esconder(Pasta);

            StringBuilder texto = new StringBuilder();

            foreach (RegistroPedido pedido in pedidos)
            {
                texto.AppendLine(Formatar(pedido));
            }

            Mostrar(Arquivo);
            File.WriteAllText(Arquivo, texto.ToString(), Encoding.UTF8);
            Esconder(Arquivo);
        }

        private static string Formatar(RegistroPedido pedido)
        {
            string itens = (pedido.Itens ?? "")
                .Replace("\r\n", " | ")
                .Replace("\r", " | ")
                .Replace("\n", " | ")
                .Replace("\t", " ");

            return string.Join("\t", new string[]
            {
                pedido.Data.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                Simples(pedido.Nome),
                Simples(pedido.Cpf),
                Simples(pedido.Pagamento),
                pedido.Total.ToString("0.00", CultureInfo.InvariantCulture),
                itens
            });
        }

        private static RegistroPedido Interpretar(string linha)
        {
            if (string.IsNullOrWhiteSpace(linha))
            {
                return null;
            }

            string[] campos = linha.Split('\t');

            RegistroPedido pedido = new RegistroPedido();
            DateTime data;
            double total;

            if (campos.Length >= 6)
            {
                pedido.Data = DateTime.TryParse(campos[0], CultureInfo.InvariantCulture, DateTimeStyles.None, out data) ? data : DateTime.MinValue;
                pedido.Nome = campos[1];
                pedido.Cpf = campos[2];
                pedido.Pagamento = campos[3];
                pedido.Total = double.TryParse(campos[4], NumberStyles.Any, CultureInfo.InvariantCulture, out total) ? total : 0.0;
                pedido.Itens = campos[5];
                return pedido;
            }

            if (campos.Length >= 4)
            { 
                pedido.Data = DateTime.TryParse(campos[0], CultureInfo.InvariantCulture, DateTimeStyles.None, out data) ? data : DateTime.MinValue;
                pedido.Nome = "";
                pedido.Cpf = "";
                pedido.Pagamento = campos[1];
                pedido.Total = double.TryParse(campos[2], NumberStyles.Any, CultureInfo.InvariantCulture, out total) ? total : 0.0;
                pedido.Itens = campos[3];
                return pedido;
            }

            return null;
        }

        private static string Simples(string texto)
        {
            if (texto == null)
            {
                return "";
            }

            return texto.Replace("\t", " ").Replace("\r", " ").Replace("\n", " ");
        }

        private static void Esconder(string caminho)
        {
            try
            {
                File.SetAttributes(caminho, File.GetAttributes(caminho) | FileAttributes.Hidden);
            }
            catch (Exception)
            {

            }
        }

        private static void Mostrar(string caminho)
        {
            try
            {
                if (File.Exists(caminho))
                {
                    File.SetAttributes(caminho, File.GetAttributes(caminho) & ~FileAttributes.Hidden);
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
