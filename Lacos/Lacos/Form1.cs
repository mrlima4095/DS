using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lacos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            int i;
            i = 0;
            while (i <= 80)
            {
                textBox1.Text += " " + i.ToString();
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            int i;
            i = 0;
            do
            {
                textBox1.Text += " " + i.ToString();
                i++;
            }
            while (i <= 80);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            for (int i = 0; i <= 50; i++)
            {
                textBox1.Text += " " + i.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            string[] nomes = { "Felipe", "Lima das vozes", "Lenda", "Sorriso", "Rei Gay" };
            foreach (string nome in nomes)
            {
                textBox1.Text += Environment.NewLine + nome;
            }
        }
    }
}
