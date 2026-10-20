using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Resturante
{
    public class Conta
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime Cadastro { get; set; }
    }

    public static class ContaStore
    {
        private static readonly string Pasta = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "PizzariaSorriso");

        private static readonly string Arquivo = Path.Combine(Pasta, "contas.dat");

        public static string CaminhoArquivo
        {
            get { return Arquivo; }
        }

        public static void Salvar(Conta conta)
        {
            Directory.CreateDirectory(Pasta);
            Esconder(Pasta);

            File.AppendAllText(Arquivo, Formatar(conta) + Environment.NewLine, Encoding.UTF8);
            Esconder(Arquivo);
        }

        public static List<Conta> Carregar()
        {
            List<Conta> lista = new List<Conta>();

            if (!File.Exists(Arquivo))
            {
                return lista;
            }

            foreach (string linha in File.ReadAllLines(Arquivo, Encoding.UTF8))
            {
                Conta conta = Interpretar(linha);

                if (conta != null)
                {
                    lista.Add(conta);
                }
            }

            return lista;
        }

        public static Conta BuscarPorCpf(string cpf)
        {
            string procurado = SomenteDigitos(cpf);

            foreach (Conta conta in Carregar())
            {
                if (SomenteDigitos(conta.Cpf) == procurado)
                {
                    return conta;
                }
            }

            return null;
        }

        public static bool CpfCadastrado(string cpf)
        {
            return BuscarPorCpf(cpf) != null;
        }

        public static bool EmailCadastrado(string email)
        {
            string procurado = (email ?? "").Trim().ToLowerInvariant();

            foreach (Conta conta in Carregar())
            {
                if ((conta.Email ?? "").Trim().ToLowerInvariant() == procurado)
                {
                    return true;
                }
            }

            return false;
        }

        public static string SomenteDigitos(string texto)
        {
            if (texto == null)
            {
                return "";
            }

            StringBuilder digitos = new StringBuilder();

            foreach (char c in texto)
            {
                if (char.IsDigit(c))
                {
                    digitos.Append(c);
                }
            }

            return digitos.ToString();
        }

        public static string FormatarCpf(string cpf)
        {
            string digitos = SomenteDigitos(cpf);

            if (digitos.Length != 11)
            {
                return (cpf ?? "").Trim();
            }

            return digitos.Substring(0, 3) + "." + digitos.Substring(3, 3) + "." + digitos.Substring(6, 3) + "-" + digitos.Substring(9, 2);
        }

        public static bool CpfValido(string cpf)
        {
            string d = SomenteDigitos(cpf);

            if (d.Length != 11)
            {
                return false;
            }

            bool todosIguais = true;

            for (int i = 1; i < 11; i++)
            {
                if (d[i] != d[0])
                {
                    todosIguais = false;
                    break;
                }
            }

            if (todosIguais)
            {
                return false;
            }

            int soma = 0;

            for (int i = 0; i < 9; i++)
            {
                soma += (d[i] - '0') * (10 - i);
            }

            int resto = (soma * 10) % 11;

            if (resto == 10)
            {
                resto = 0;
            }

            if (resto != (d[9] - '0'))
            {
                return false;
            }

            soma = 0;

            for (int i = 0; i < 10; i++)
            {
                soma += (d[i] - '0') * (11 - i);
            }

            resto = (soma * 10) % 11;

            if (resto == 10)
            {
                resto = 0;
            }

            return resto == (d[10] - '0');
        }

        public static bool EmailValido(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }

            return Regex.IsMatch(email.Trim(), @"^[^@\s]+@[^@\s]+\.[A-Za-z]{2,}$");
        }

        public static bool NomeValido(string nome)
        {
            if (string.IsNullOrEmpty(nome) || Regex.IsMatch(nome, "[0-9]"))
            {
                return false;
            }

            string[] partes = nome.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (partes.Length < 2)
            {
                return false;
            }

            return partes[0].Length >= 2 && partes[partes.Length - 1].Length >= 2;
        }

        private static string Formatar(Conta conta)
        {
            return string.Join("\t", new string[]
            {
                Simples(conta.Nome),
                Simples(conta.Email),
                Simples(conta.Cpf),
                conta.Cadastro.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
            });
        }

        private static Conta Interpretar(string linha)
        {
            if (string.IsNullOrWhiteSpace(linha))
            {
                return null;
            }

            string[] campos = linha.Split('\t');

            if (campos.Length < 3)
            {
                return null;
            }

            Conta conta = new Conta();
            DateTime data;

            conta.Nome = campos[0];
            conta.Email = campos[1];
            conta.Cpf = campos[2];
            conta.Cadastro = campos.Length >= 4 && DateTime.TryParse(campos[3], CultureInfo.InvariantCulture, DateTimeStyles.None, out data)
                ? data
                : DateTime.MinValue;

            return conta;
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
    }
}
