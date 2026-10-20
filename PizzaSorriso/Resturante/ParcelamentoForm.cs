using System;
using System.Windows.Forms;

namespace Resturante
{
    public partial class ParcelamentoForm : Form
    {
        public ParcelamentoForm()
            : this(0.0)
        {
        }

        public ParcelamentoForm(double total)
        {
            InitializeComponent();

            for (int i = 1; i <= 12; i++)
            {
                cboParcelas.Items.Add(i + "x de R$ " + (total / i).ToString("0.00"));
            }

            cboParcelas.SelectedIndex = 0;
        }

        public int Parcelas
        {
            get { return cboParcelas.SelectedIndex + 1; }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }
    }
}
