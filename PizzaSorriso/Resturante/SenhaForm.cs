using System;
using System.Windows.Forms;

namespace Resturante
{
    /// <summary>
    /// Janela que pede a senha do administrador antes de abrir o painel.
    /// </summary>
    public partial class SenhaForm : Form
    {
        private readonly string senhaCerta;

        public SenhaForm()
            : this("")
        {
        }

        public SenhaForm(string senha)
        {
            InitializeComponent();
            senhaCerta = senha;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == senhaCerta)
            {
                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            MessageBox.Show("Senha incorreta.", "Acesso restrito", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtSenha.Clear();
            txtSenha.Focus();
        }
    }
}
