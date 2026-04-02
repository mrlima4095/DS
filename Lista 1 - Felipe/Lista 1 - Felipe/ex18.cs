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
    public partial class ex18 : Form
    {
        public ex18()
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

            double salario_bruto = Convert.ToDouble(textBox1.Text);
            double previdencia = salario_bruto * (10 / 100.0), imposto = (salario_bruto - previdencia) * (5 / 100.0);

            result_textBox.Text = "Salario Bruto: R$ " + salario_bruto + Environment.NewLine + "Salario Líquido: R$ " + (salario_bruto - previdencia - imposto).ToString("F2") + Environment.NewLine + "Previdencia (10%): R$ " + previdencia.ToString("F2") + Environment.NewLine + "Imposto (5%): R$ " + imposto.ToString("F2");

        }
    }
}
