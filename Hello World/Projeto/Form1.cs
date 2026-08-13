using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            string nome_completo = textBox1.Text;
            if (nome_completo == "")
            {
                label2.Text = "Eii, por favor insira seu nome!";
                return;
            }
            nome_completo += " " + textBox2.Text;
            
            
            label2.Text = "Olá, " + nome_completo;
            textBox1.Text = ""; textBox2.Text = "";           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); textBox2.Clear(); label2.Text = "";
        }
        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
