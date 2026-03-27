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
    public partial class ex13 : Form
    {
        public ex13()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e) { textBox1.Text = ""; textBox2.Text = ""; result_textBox.Text = ""; }
        private void exitBtn_Click(object sender, EventArgs e) { this.Close(); }

        private void fireBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                result_textBox.Text = "Preencha todos os campos deste formulario para realizar a operação!";
            }

            int num1 = Convert.ToInt32(textBox1.Text), num2 = Convert.ToInt32(textBox2.Text);
            double q_num1 = System.Math.Pow(num1, 2), q_num2 = System.Math.Pow(num2, 2);
            int soma = Convert.ToInt32(q_num1 + q_num2);

            result_textBox.Text = num1 + "² + " + num2 + "² = " + soma;
        }
    }
}