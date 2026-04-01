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
    public partial class ex19 : Form
    {
        public ex19()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e) { textBox1.Text = ""; result_textBox.Text = ""; }
        private void exitBtn_Click(object sender, EventArgs e) { this.Close(); }

        private void fireBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                result_textBox.Text = "Preencha todos os campos deste formulario para realizar a operação!";
            }

            try
            {
                Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                result_textBox.Text = "Numero Invalido!";
                return;
            }

            string data = textBox1.Text;
            string dia = data.Substring(0, 2), mes = data.Substring(2, 2), ano = data.Substring(4, data.Length == 8 ? 4 : 2);
            result_textBox.Text = ano + "/" + mes + "/" + dia;
        }
    }
}