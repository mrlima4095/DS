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
    public partial class ex3 : Form
    {
        public ex3()
        {
            InitializeComponent();
        }

        private void ex1_Load(object sender, EventArgs e)
        {

        }
        private void clearBtn_Click(object sender, EventArgs e) {  textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; result_textBox.Text = ""; }
        private void exitBtn_Click(object sender, EventArgs e) { this.Close(); }

        private void ex_Title_Click(object sender, EventArgs e)
        {

        }

        private void fireBtn_Click(object sender, EventArgs e)
        {
            int worked_hours = 0;
            double hour_price = 0.0, descount = 0.0;

            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) | String.IsNullOrEmpty(textBox3.Text))
            {
                result_textBox.Text = "Preencha todos os campos obrigatorios!";
                return;
            }

            worked_hours = Convert.ToInt32(textBox1.Text);
            hour_price = Convert.ToDouble(textBox2.Text);
            descount = Convert.ToDouble(textBox3.Text);

            double brute_salary = worked_hours * hour_price;
            double total_descount = (descount / 100) * brute_salary;
            double final_salary = brute_salary - total_descount;

            clearBtn_Click(this, new EventArgs());
            result_textBox.AppendText("Horas Trabalhadas: " + worked_hours + " hora(s)\t");
            result_textBox.AppendText("Valor da hora: R$ " + hour_price);
            result_textBox.AppendText("\tPercentual de desconto: " + descount + "%" + Environment.NewLine);
            result_textBox.AppendText("Resultado:" + Environment.NewLine + "Salario Bruto: R$ " + String.Format("{0:F2}", brute_salary) + Environment.NewLine);
            result_textBox.AppendText("Total do desconto: R$ " + String.Format("{0:F2}", total_descount) + Environment.NewLine);
            result_textBox.AppendText("Salario Liquido: R$ " + String.Format("{0:F2}", final_salary));
        }
    }
}