using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mes = textBox1.Text.ToString();
            switch (mes)
            {
                case "janeiro":
                case "março":
                case "maio":
                case "julho":
                case "agosto":
                case "outubro":
                case "dezembro":
                    textBox3.Text = "Este mês tem 31 dias";
                    break;

                case "fevereiro":
                    textBox3.Text = "Este mês tem 28/29 dias";
                    break;

                case "abril":
                case "junho":
                case "setembro":
                case "novembro":
                    textBox3.Text = "Este mês tem 30 dias";
                    break;
                default:
                    textBox3.Text = "Este mês não existe.... LMAO!";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
