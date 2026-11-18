using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturante
{
    public partial class AdminForm : Form
    {
        private List<RegistroPedido> pedidos = new List<RegistroPedido>();

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarDetalhe(listBox1.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indice = listBox1.SelectedIndex;

            if (indice < 0 || indice >= pedidos.Count)
            {
                MessageBox.Show("Selecione um pedido na lista para apagar.", "Administrador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            RegistroPedido pedido = pedidos[indice];

            string pergunta = "Apagar o pedido de " + NomeDe(pedido)
                + " (" + pedido.Data.ToString("dd/MM/yyyy HH:mm") + ")?";

            DialogResult resposta = MessageBox.Show(pergunta, "Apagar pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resposta != DialogResult.Yes)
            {
                return;
            }

            PedidoStore.Remover(indice);
            Atualizar();
        }

        private void Atualizar()
        {
            int selecionado = listBox1.SelectedIndex;

            pedidos = PedidoStore.Carregar();

            double faturamento = 0.0;

            listBox1.BeginUpdate();
            listBox1.Items.Clear();

            for (int i = 0; i < pedidos.Count; i++)
            {
                faturamento += pedidos[i].Total;
                listBox1.Items.Add(Resumo(pedidos[i]));
            }

            listBox1.EndUpdate();

            label2.Text = "Pedidos: " + pedidos.Count
                + "     Faturamento: R$ " + faturamento.ToString("0.00");

            if (pedidos.Count == 0)
            {
                textBox1.Text = "Nenhum pedido registrado ainda.";
                return;
            }

            if (selecionado < 0 || selecionado >= pedidos.Count)
            {
                selecionado = pedidos.Count - 1;
            }

            listBox1.SelectedIndex = selecionado;
            MostrarDetalhe(selecionado);
        }

        private void MostrarDetalhe(int indice)
        {
            if (indice < 0 || indice >= pedidos.Count)
            {
                return;
            }

            RegistroPedido pedido = pedidos[indice];
            StringBuilder texto = new StringBuilder();

            texto.AppendLine("Pedido " + (indice + 1) + " de " + pedidos.Count);
            texto.AppendLine("Hora do pedido: " + pedido.Data.ToString("dd/MM/yyyy HH:mm:ss"));
            texto.AppendLine("Cliente: " + NomeDe(pedido));
            texto.AppendLine("CPF na nota: " + (string.IsNullOrEmpty(pedido.Cpf) ? "(não informado)" : pedido.Cpf));
            texto.AppendLine("Pagamento: " + pedido.Pagamento);
            texto.AppendLine(new string('-', 60));
            texto.AppendLine(pedido.Itens);
            texto.AppendLine(new string('-', 60));
            texto.AppendLine("Subtotal: R$ " + pedido.Subtotal.ToString("0.00"));

            if (pedido.Desconto > 0)
            {
                texto.AppendLine("Desconto: R$ " + pedido.Desconto.ToString("0.00") + (pedido.Cupom ? " (cupom)" : ""));
            }

            texto.AppendLine("Total: R$ " + pedido.Total.ToString("0.00"));

            textBox1.Text = texto.ToString();
            textBox1.SelectionStart = 0;
            textBox1.ScrollToCaret();
        }

        private static string Resumo(RegistroPedido pedido)
        {
            return pedido.Data.ToString("dd/MM/yyyy HH:mm") + "   " + NomeDe(pedido)
                + "   -   R$ " + pedido.Total.ToString("0.00");
        }

        private static string NomeDe(RegistroPedido pedido)
        {
            return string.IsNullOrEmpty(pedido.Nome) ? "(sem nome)" : pedido.Nome;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
