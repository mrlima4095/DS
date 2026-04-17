using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desvio_Condicional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void desvioCondicionalSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            form.FormClosed += (s, args) => { this.Show(); };
            this.Hide();
        }

        private void desvioCondicionalCompostoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            form.FormClosed += (s, args) => { this.Show(); };
            this.Hide();
        }

        private void desvioCondicionalEncadeadoifElseifToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            form.FormClosed += (s, args) => { this.Show(); };
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult question = MessageBox.Show("Tem certeza?", "Atenção", MessageBoxButtons.YesNo);
            if (question == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
