using System;
using System.Windows.Forms;

namespace Resturante
{
    public partial class LoginForm : Form
    {
        public Conta Usuario { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string cpf = ContaStore.FormatarCpf(txtCpf.Text);

            if (!ContaStore.CpfValido(cpf))
            {
                MessageBox.Show(
                    "Digite um CPF válido para entrar. Se ainda não tem conta, clique em \"Criar conta\".",
                    "Pizzaria Sorriso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtCpf.Focus();
                txtCpf.SelectAll();
                return;
            }

            Conta conta = ContaStore.BuscarPorCpf(cpf);

            if (conta == null)
            {
                MessageBox.Show(
                    "Esse CPF ainda não está cadastrado. Crie uma conta ou entre como convidado.",
                    "Pizzaria Sorriso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtCpf.Focus();
                txtCpf.SelectAll();
                return;
            }

            Usuario = conta;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            using (CadastroForm cadastro = new CadastroForm())
            {
                if (cadastro.ShowDialog(this) == DialogResult.OK)
                {
                    Usuario = cadastro.ContaCadastrada;
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void btnConvidado_Click(object sender, EventArgs e)
        {
            Usuario = null;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            txtCpf.Text = ContaStore.FormatarCpf(txtCpf.Text);
        }
    }
}
