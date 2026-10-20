using System;
using System.Drawing;
using System.Windows.Forms;

namespace Resturante
{
    public partial class Splash : Form
    {
        private const string SenhaAdmin = "1234";

        private int progressoAtual = 0;

        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            if (PedirSenha())
            {
                using (AdminForm admin = new AdminForm())
                {
                    admin.ShowDialog(this);
                }

                Finalizar();
            }
            else
            {
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressoAtual += 1;

            if (progressoAtual >= progresso.Maximum)
            {
                progresso.Value = progresso.Maximum;
                Finalizar();
                return;
            }

            progresso.Value = progressoAtual;
        }

        private bool PedirSenha()
        {
            using (SenhaForm senha = new SenhaForm(SenhaAdmin))
            {
                return senha.ShowDialog(this) == DialogResult.OK;
            }
        }

        private void Finalizar()
        {
            timer1.Stop();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
