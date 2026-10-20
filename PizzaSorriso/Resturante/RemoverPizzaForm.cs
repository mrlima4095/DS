using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Resturante
{
    public partial class RemoverPizzaForm : Form
    {
        public RemoverPizzaForm()
            : this(new List<PizzaPedido>())
        {
        }

        public RemoverPizzaForm(List<PizzaPedido> pizzas)
        {
            InitializeComponent();

            foreach (PizzaPedido pizza in pizzas)
            {
                lstPizzas.Items.Add(pizza);
            }

            if (lstPizzas.Items.Count > 0)
            {
                lstPizzas.SelectedIndex = 0;
            }
        }

        public int IndiceSelecionado
        {
            get { return lstPizzas.SelectedIndex; }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (lstPizzas.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione a pizza que deseja remover.", "Remover pizza", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void lstPizzas_DoubleClick(object sender, EventArgs e)
        {
            btnRemover_Click(sender, e);
        }
    }
}
