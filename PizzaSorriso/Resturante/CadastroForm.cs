using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturante
{
    public partial class CadastroForm : Form
    {
        public Conta ContaCadastrada { get; private set; }

        public CadastroForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text.Trim();
            string email = textBox2.Text.Trim();
            string cpf = ContaStore.SomenteDigitos(textBox3.Text);
            string senha = textBox4.Text;

            if (!ContaStore.NomeValido(nome))
            {
                Avisar("Digite seu nome completo, com nome e sobrenome.", textBox1);
                return;
            }

            if (!ContaStore.EmailValido(email))
            {
                Avisar("Digite um e-mail válido.", textBox2);
                return;
            }

            if (!ContaStore.CpfValido(cpf))
            {
                Avisar("Esse CPF não é válido. Confira os números.", textBox3);
                return;
            }

            if (senha.Length < 4)
            {
                Avisar("A senha precisa ter pelo menos 4 caracteres.", textBox4);
                return;
            }

            if (ContaStore.CpfCadastrado(cpf))
            {
                Avisar("Já existe uma conta com esse CPF. Faça login com ele.", textBox3);
                return;
            }

            if (ContaStore.EmailCadastrado(email))
            {
                Avisar("Já existe uma conta com esse e-mail.", textBox2);
                return;
            }

            Conta conta = new Conta();
            conta.Nome = nome;
            conta.Email = email;
            conta.Cpf = cpf;
            conta.Cadastro = DateTime.Now;
            conta.Senha = senha;

            ContaStore.Salvar(conta);

            ContaCadastrada = conta;

            MessageBox.Show("Conta criada com sucesso! Bem-vindo(a), " + nome + ".", "Pizzaria Sorriso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Avisar(string mensagem, Control campo)
        {
            MessageBox.Show(mensagem, "Criar conta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            campo.Focus();

            TextBox caixa = campo as TextBox;
            if (caixa != null)
            {
                caixa.SelectAll();
            }
        }
    }
}
