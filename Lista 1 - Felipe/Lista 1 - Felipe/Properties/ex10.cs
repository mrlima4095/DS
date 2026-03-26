using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_1___Felipe
{
    public partial class ex10 : Form
    {
        public ex10()
        {
            InitializeComponent();
        }

        private void ex1_Load(object sender, EventArgs e)
        {

        }
        private void clearBtn_Click(object sender, EventArgs e) { textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; result_textBox.Text = ""; }
        private void exitBtn_Click(object sender, EventArgs e) { this.Close(); }

        private void ex_Title_Click(object sender, EventArgs e)
        {

        }

        private void fireBtn_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) | String.IsNullOrEmpty(textBox3.Text))
            {
                result_textBox.Text = "Preencha todos os campos obrigatorios!";
                return;
            }

            double comprimento = Convert.ToDouble(textBox1.Text), largura = Convert.ToDouble(textBox2.Text), altura = Convert.ToDouble(textBox3.Text);

            result_textBox.Text = "Volume = " + (comprimento * largura * altura);
        }
    }
}