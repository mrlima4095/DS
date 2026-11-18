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
    public partial class Splash : Form
    {
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
                AdminForm admin = new AdminForm();
                admin.ShowDialog(this);

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

            if (progressoAtual >= progressBar1.Maximum)
            {
                progressBar1.Value = progressBar1.Maximum;
                Finalizar();
                return;
            }

            progressBar1.Value = progressoAtual;
        }

        private bool PedirSenha()
        {
            SenhaForm senha = new SenhaForm();

            if (senha.ShowDialog(this) == DialogResult.OK)
            {
                return true;
            }

            return false;
        }

        private void Finalizar()
        {
            timer1.Stop();
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
