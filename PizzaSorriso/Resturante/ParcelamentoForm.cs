using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturante
{
    public partial class ParcelamentoForm : Form
    {
        public ParcelamentoForm(double total)
        {
            InitializeComponent();

            for (int i = 1; i <= 12; i++)
            {
                comboBox1.Items.Add(i + "x de R$ " + (total / i).ToString("0.00"));
            }

            comboBox1.SelectedIndex = 0;
        }

        public int Parcelas
        {
            get { return comboBox1.SelectedIndex + 1; }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
