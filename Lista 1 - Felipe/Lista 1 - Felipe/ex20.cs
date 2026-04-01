using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lista_1___Felipe
{
    public partial class ex20: Form
    {
        public ex20()
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

            string cod = textBox1.Text;
            string ano = cod.Substring(0, 2), semestre = cod.Substring(2, 1), ordem = cod.Substring(3, 3);
            result_textBox.Text = "Ano da matricula: " + ano + Environment.NewLine + "Semestre: " + semestre + Environment.NewLine + "Nº Ordem: " + ordem;
        }
    }
}