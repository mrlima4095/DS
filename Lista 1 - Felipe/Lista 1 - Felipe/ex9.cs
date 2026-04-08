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
    public partial class ex9 : Form
    {
        public ex9()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e) { textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = ""; result_textBox.Text = ""; }
        private void exitBtn_Click(object sender, EventArgs e) { this.Close(); }

        private void fireBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(textBox4.Text))
            {
                result_textBox.Text = "Preencha todos os campos deste formulario para realizar a operação!";
            }

            double a = Convert.ToDouble(textBox1.Text), b = Convert.ToDouble(textBox2.Text), c = Convert.ToDouble(textBox3.Text), d = Convert.ToDouble(textBox4.Text);

            result_textBox.Text = "Adições: A+B=" + (a + b) + ", A+C=" + (a + c) + ", A+D=" + (a + d) + ", B+C=" + (b + c) + ", B+D=" + (b + d) + ", C+D=" + (c + d) + Environment.NewLine + "Multiplicações: " + (a * b) + ", " + (a * c) + ", " + (a * d) + ", " + (b * c) + ", " + (b * d) + ", " + (c * d);        }
    }
}
/*
9. Faça um algoritmo que leia quatro números e apresente os resultados de adição e multiplicação dos valores 
entre si, baseando-se na utilização da propriedade distributiva, ou seja, se forem lidas as variáveis A, B, C e D, 
devem ser somadas e multiplicadas A com B, A com C e A com D; B com C, B com D e por último C com D.
 */