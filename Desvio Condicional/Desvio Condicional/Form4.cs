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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota = Convert.ToDouble(textBox1.Text);
            if (nota <= 10 && nota >= 9)
            {
                MessageBox.Show("A", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (nota < 9 && nota >= 7)
            {
                MessageBox.Show("B", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (nota < 7 && nota >= 5)
            {
                MessageBox.Show("C", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else if (nota < 5 && nota >= 0)
            {
                MessageBox.Show("D", "Nota", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show(nota < 0 ? "Você é muito burro..." : "Valor invalido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
