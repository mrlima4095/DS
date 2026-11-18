using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Resturante
{
    public class Conta
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime Cadastro { get; set; }
        public string Senha { get; set; }
    }

    public static class ContaStore
    {
        public static void Salvar(Conta conta)
        {
            string linha = conta.Nome + "\t" + conta.Email + "\t" + conta.Cpf + "\t" + conta.Cadastro.ToString("yyyy-MM-dd HH:mm:ss") + "\t" + conta.Senha;

            File.AppendAllText(Application.StartupPath + "\\contas.txt", linha + Environment.NewLine, Encoding.UTF8);
        }

        public static List<Conta> Carregar()
        {
            List<Conta> contas = new List<Conta>();
            string caminho = Application.StartupPath + "\\contas.txt";

            if (File.Exists(caminho) == false)
            {
                return contas;
            }

            string[] linhas = File.ReadAllLines(caminho, Encoding.UTF8);

            for (int i = 0; i < linhas.Length; i++)
            {
                string[] campos = linhas[i].Split('\t');

                if (campos.Length < 3)
                {
                    continue;
                }

                Conta conta = new Conta();
                DateTime data;

                conta.Nome = campos[0];
                conta.Email = campos[1];
                conta.Cpf = campos[2];
                conta.Senha = "";

                if (campos.Length >= 4 && DateTime.TryParse(campos[3], out data))
                {
                    conta.Cadastro = data;
                }
                else
                {
                    conta.Cadastro = DateTime.MinValue;
                }

                if (campos.Length >= 5)
                {
                    conta.Senha = campos[4];
                }

                contas.Add(conta);
            }

            return contas;
        }

        public static Conta BuscarPorCpf(string cpf)
        {
            string procurado = SomenteDigitos(cpf);
            List<Conta> contas = Carregar();

            for (int i = 0; i < contas.Count; i++)
            {
                if (SomenteDigitos(contas[i].Cpf) == procurado)
                {
                    return contas[i];
                }
            }

            return null;
        }

        public static bool CpfCadastrado(string cpf)
        {
            if (BuscarPorCpf(cpf) == null)
            {
                return false;
            }

            return true;
        }

        public static bool EmailCadastrado(string email)
        {
            string procurado = email;

            if (procurado == null)
            {
                procurado = "";
            }

            procurado = procurado.Trim().ToLower();

            List<Conta> contas = Carregar();

            for (int i = 0; i < contas.Count; i++)
            {
                string emailConta = contas[i].Email;

                if (emailConta == null)
                {
                    emailConta = "";
                }

                if (emailConta.Trim().ToLower() == procurado)
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

            string digitos = "";

            for (int i = 0; i < texto.Length; i++)
            {
                if (char.IsDigit(texto[i]))
                {
                    digitos += texto[i];
                }
            }

            return digitos;
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

            if (resto != (d[10] - '0'))
            {
                return false;
            }

            return true;
        }

        public static bool EmailValido(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                return false;
            }

            if (Regex.IsMatch(email.Trim(), @"^[^@\s]+@[^@\s]+\.[A-Za-z]{2,}$") == false)
            {
                return false;
            }

            return true;
        }

        public static bool NomeValido(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                return false;
            }

            if (Regex.IsMatch(nome, "[0-9]"))
            {
                return false;
            }

            string[] partes = nome.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (partes.Length < 2)
            {
                return false;
            }

            if (partes[0].Length < 2)
            {
                return false;
            }

            if (partes[partes.Length - 1].Length < 2)
            {
                return false;
            }

            return true;
        }
    }
}
