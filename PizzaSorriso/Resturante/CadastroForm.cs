using System;
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();
            string email = txtEmail.Text.Trim();
            string cpf = ContaStore.FormatarCpf(txtCpf.Text);

            if (!ContaStore.NomeValido(nome))
            {
                Avisar("Informe o nome completo, com nome e sobrenome (sem números).", txtNome);
                return;
            }

            if (!ContaStore.EmailValido(email))
            {
                Avisar("Informe um e-mail válido, no formato nome@provedor.com.", txtEmail);
                return;
            }

            if (!ContaStore.CpfValido(cpf))
            {
                Avisar("Esse CPF não é válido. Confira os números digitados.", txtCpf);
                return;
            }

            if (ContaStore.CpfCadastrado(cpf))
            {
                Avisar("Já existe uma conta com esse CPF. Volte e faça login com ele.", txtCpf);
                return;
            }

            if (ContaStore.EmailCadastrado(email))
            {
                Avisar("Já existe uma conta com esse e-mail.", txtEmail);
                return;
            }

            Conta conta = new Conta();
            conta.Nome = nome;
            conta.Email = email;
            conta.Cpf = cpf;
            conta.Cadastro = DateTime.Now;

            ContaStore.Salvar(conta);

            ContaCadastrada = conta;

            MessageBox.Show(
                "Conta criada com sucesso! Bem-vindo(a), " + nome + ".",
                "Pizzaria Sorriso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            txtCpf.Text = ContaStore.FormatarCpf(txtCpf.Text);
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
