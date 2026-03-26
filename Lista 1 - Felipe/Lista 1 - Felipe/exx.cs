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
    public partial class ex4 : Form
    {
        public ex4()
        {
            InitializeComponent();
        }

        private void ex1_Load(object sender, EventArgs e)
        {

        }
        private void clearBtn_Click(object sender, EventArgs e) {  textBox1.Text = "";  result_textBox.Text = ""; }
        private void exitBtn_Click(object sender, EventArgs e) { this.Close(); }

        private void ex_Title_Click(object sender, EventArgs e)
        {

        }
        private void fireBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                result_textBox.Text = "Preencha todos os campos deste formulario para realizar a operação!";
            }

            double temp = Convert.ToDouble(textBox1.Text);

            result_textBox.Text = temp + " ºC = " + ((9 * temp + 160) / 5) + " ºF";
        }
    }
}