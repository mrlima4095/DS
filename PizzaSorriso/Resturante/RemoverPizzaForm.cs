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
    public partial class RemoverPizzaForm : Form
    {

        public RemoverPizzaForm(List<PizzaPedido> pizzas)
        {
            InitializeComponent();

            foreach (PizzaPedido pizza in pizzas)
            {
                listBox1.Items.Add(pizza);
            }

            if (listBox1.Items.Count > 0)
            {
                listBox1.SelectedIndex = 0;
            }
        }

        public int IndiceSelecionado
        {
            get { return listBox1.SelectedIndex; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione a pizza que deseja remover.", "Remover pizza", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }
    }
}
