using System;
using System.Windows.Forms;

namespace Resturante
{
    public partial class ClienteForm : Form
    {
        public string Nome { get; private set; }

        public string Cpf { get; private set; }

        public ClienteForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text.Trim();

            if (nome.Length < 2)
            {
                MessageBox.Show("Informe o nome do cliente para a nota.", "Cliente do pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }

            string cpf = ContaStore.SomenteDigitos(txtCpf.Text);

            if (cpf != "" && !ContaStore.CpfValido(cpf))
            {
                MessageBox.Show("Esse CPF não é válido. Deixe em branco se não quiser o CPF na nota.", "Cliente do pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCpf.Focus();
                txtCpf.SelectAll();
                return;
            }

            Nome = nome;
            Cpf = ContaStore.FormatarCpf(cpf);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void txtCpf_Leave(object sender, EventArgs e)
        {
            txtCpf.Text = ContaStore.FormatarCpf(txtCpf.Text);
        }
    }
}
