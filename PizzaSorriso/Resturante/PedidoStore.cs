using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Resturante
{
    public class RegistroPedido
    {
        public DateTime Data { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Pagamento { get; set; }
        public double Subtotal { get; set; }
        public double Desconto { get; set; }
        public bool Cupom { get; set; }
        public double Total { get; set; }
        public string Itens { get; set; }
    }

    public static class PedidoStore
    {
        private static string Caminho
        {
            get { return Application.StartupPath + "\\pedidos.txt"; }
        }

        public static void Salvar(RegistroPedido pedido)
        {
            string separador = "";

            // O arquivo reescrito por Remover() termina com quebra de linha.
            // Se o arquivo vier de uma versão antiga, acrescenta a quebra antes
            // para não emendar dois pedidos na mesma linha.
            if (File.Exists(Caminho))
            {
                string conteudo = File.ReadAllText(Caminho, Encoding.UTF8);

                if (conteudo.Length > 0 && conteudo[conteudo.Length - 1] != '\n')
                {
                    separador = Environment.NewLine;
                }
            }

            File.AppendAllText(Caminho, separador + Formatar(pedido) + Environment.NewLine, Encoding.UTF8);
        }

        public static List<RegistroPedido> Carregar()
        {
            List<RegistroPedido> pedidos = new List<RegistroPedido>();
            string caminho = Caminho;

            if (!File.Exists(caminho))
            {
                return pedidos;
            }

            string[] linhas = File.ReadAllLines(caminho, Encoding.UTF8);

            for (int i = 0; i < linhas.Length; i++)
            {
                string[] campos = linhas[i].Split('\t');

                if (campos.Length < 9)
                {
                    continue;
                }

                RegistroPedido pedido = new RegistroPedido();
                DateTime data;
                double total;
                double subtotal;
                double desconto;

                DateTime.TryParse(campos[0], CultureInfo.InvariantCulture, DateTimeStyles.None, out data);
                double.TryParse(campos[4], NumberStyles.Any, CultureInfo.InvariantCulture, out total);
                double.TryParse(campos[6], NumberStyles.Any, CultureInfo.InvariantCulture, out subtotal);
                double.TryParse(campos[7], NumberStyles.Any, CultureInfo.InvariantCulture, out desconto);

                pedido.Data = data;
                pedido.Nome = campos[1];
                pedido.Cpf = campos[2];
                pedido.Pagamento = campos[3];
                pedido.Total = total;
                pedido.Itens = campos[5].Replace("\\n", Environment.NewLine);
                pedido.Subtotal = subtotal;
                pedido.Desconto = desconto;
                pedido.Cupom = campos[8] == "1";

                pedidos.Add(pedido);
            }

            return pedidos;
        }

        public static void Remover(int indice)
        {
            List<RegistroPedido> pedidos = Carregar();

            if (indice < 0 || indice >= pedidos.Count)
            {
                return;
            }

            pedidos.RemoveAt(indice);

            List<string> linhas = new List<string>();

            for (int i = 0; i < pedidos.Count; i++)
            {
                linhas.Add(Formatar(pedidos[i]));
            }

            string texto = "";

            if (linhas.Count > 0)
            {
                // Sempre termina com quebra de linha para o próximo Salvar()
                // começar em uma linha nova.
                texto = string.Join(Environment.NewLine, linhas.ToArray()) + Environment.NewLine;
            }

            File.WriteAllText(Caminho, texto, Encoding.UTF8);
        }

        public static bool TemCupom(string cpf)
        {
            string procurado = ContaStore.SomenteDigitos(cpf);

            if (procurado == "")
            {
                return false;
            }

            int pedidosValidos = 0;
            int cuponsUsados = 0;

            foreach (RegistroPedido pedido in Carregar())
            {
                if (ContaStore.SomenteDigitos(pedido.Cpf) != procurado)
                {
                    continue;
                }

                if (pedido.Subtotal >= 100.0)
                {
                    pedidosValidos++;
                }

                if (pedido.Cupom)
                {
                    cuponsUsados++;
                }
            }

            return pedidosValidos / 5 > cuponsUsados;
        }

        private static string Formatar(RegistroPedido pedido)
        {
            string itens = pedido.Itens;

            if (itens == null)
            {
                itens = "";
            }

            itens = itens.Replace(Environment.NewLine, "\\n");
            itens = itens.Replace("\r", "\\n");
            itens = itens.Replace("\n", "\\n");
            itens = itens.Replace("\t", " ");

            string linha = pedido.Data.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            linha += "\t" + pedido.Nome;
            linha += "\t" + pedido.Cpf;
            linha += "\t" + pedido.Pagamento;
            linha += "\t" + pedido.Total.ToString("0.00", CultureInfo.InvariantCulture);
            linha += "\t" + itens;
            linha += "\t" + pedido.Subtotal.ToString("0.00", CultureInfo.InvariantCulture);
            linha += "\t" + pedido.Desconto.ToString("0.00", CultureInfo.InvariantCulture);

            if (pedido.Cupom)
            {
                linha += "\t1";
            }
            else
            {
                linha += "\t0";
            }

            return linha;
        }
    }
}
