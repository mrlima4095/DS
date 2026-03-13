using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            int worked_hours = 0;
            double hour_price = 0.0, descount = 0.0;
            
            if (String.IsNullOrEmpty(horasField.Text) || String.IsNullOrEmpty(valorHoraField.Text) | String.IsNullOrEmpty(descontoField.Text))
            {
                resultadoField.Text = "Preencha todos os campos obrigatorios!";
                return;
            }

            worked_hours = Convert.ToInt32(horasField.Text);
            hour_price = Convert.ToDouble(valorHoraField.Text);
            descount = Convert.ToDouble(descontoField.Text);

            double brute_salary = worked_hours * hour_price;
            double total_descount = (descount / 100) * brute_salary;
            double final_salary = brute_salary - total_descount;

            clearBtn_Click(this, new EventArgs());
            resultadoField.AppendText("Horas Trabalhadas: " + worked_hours + " hora(s)" + Environment.NewLine);
            resultadoField.AppendText("Valor da hora: R$ " + hour_price + Environment.NewLine);
            resultadoField.AppendText("Percentual de desconto: " + descount + "%" + Environment.NewLine + Environment.NewLine);
            resultadoField.AppendText("Resultado:" + Environment.NewLine + "Salario Bruto: R$ " + String.Format("{0:F2}", brute_salary) + Environment.NewLine);
            resultadoField.AppendText("Total do desconto: R$ " + String.Format("{0:F2}", total_descount) + Environment.NewLine);
            resultadoField.AppendText("Salario Liquido: R$ " + String.Format("{0:F2}", final_salary));
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            horasField.Clear();
            valorHoraField.Clear();
            descontoField.Clear();
            resultadoField.Clear();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
