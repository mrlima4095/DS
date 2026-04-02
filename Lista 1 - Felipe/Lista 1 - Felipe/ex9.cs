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

        private void fireBtn_example(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                result_textBox.Text = "Preencha todos os campos deste formulario para realizar a operação!";
            }
        }
        private void clearBtn_Click(object sender, EventArgs e) { textBox1.Text = ""; textBox2.Text = ""; result_textBox.Text = ""; }
        private void exitBtn_Click(object sender, EventArgs e) { this.Close(); }
    }
}
/*
9. Faça um algoritmo que leia quatro números e apresente os resultados de adição e multiplicação dos valores 
entre si, baseando-se na utilização da propriedade distributiva, ou seja, se forem lidas as variáveis A, B, C e D, 
devem ser somadas e multiplicadas A com B, A com C e A com D; B com C, B com D e por último C com D.
 */