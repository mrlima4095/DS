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
    public partial class Form1 : Form
    {
        public enum FormaPagamento
        {
            Nenhuma,
            CartaoCredito,
            CartaoDebito,
            Dinheiro,
            Pix
        }

        public string Sabor_Pizza = "";
        public double Sabor_Pizza_Preco = 0.0;
        public FormaPagamento Forma_de_Pagamento = FormaPagamento.Nenhuma;
        public string[] Adicionais = new string[2] { "Borda Recheada", "Recheio em dobro" };
        public string[] Adicionais_Pedidos = new string[2] { null, null };
        public double[] Adicionais_Preco = new double[2] { 7.0, 8.0 };
        public string[] Pedido_Acomp = new string[4] { null, null, null, null };
        public int[] Pedido_Acomp_Qntd = new int[4] { 0, 0, 0, 0 };
        public string[] Pedido_Bebidas = new string[8] { null, null, null, null, null, null, null, null };
        public int[] Pedido_Bebidas_Qntd = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };

        public string[] Acompanhamentos = { "Pastel de Carne", "Pastel de Queijo", "Esfiha de Carne", "Esfiha de Queijo" };
        public double[] Acompanhamentos_preco = { 9.0, 9.0, 8.0, 8.0 };
        public string[] Bebidas = { "Água", "Água com Gás", "Suco de Manga", "Suco de Laranja", "Limonada", "Coca Cola", "Guaraná", "Fanta Uva" };
        public double[] Bebidas_preco = { 4.0, 5.0, 8.0, 7.0, 6.0, 7.0, 6.0, 7.0 };
        public string[] pratos_principais = { "Mussarela", "Calabresa", "Frango com Catupiry", "3 Queijos", "Portuguesa", "Napolitana", "Pepperoni", "Chocolate" };
        public double[] pratos_principais_preco = { 34.0, 36.0, 38.0, 36.0, 38.0, 32.0, 42.0, 18.0 };

        public int qntd_Pizza = 0;
        public List<PizzaPedido> pizzas = new List<PizzaPedido>();

        public Conta UsuarioLogado = null;
        
        
        public Form1()
        {
            InitializeComponent();
        }
          
        private void button3_Click(object sender, EventArgs e)
        {
            if (!formularioAlterado())
            {
                Application.Exit();
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Deseja realmente sair? O estado atual do pedido será perdido.",
                "Sair",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private bool formularioAlterado()
        {
            if (!pedidoVazio())
            {
                return true;
            }

            if (Forma_de_Pagamento != FormaPagamento.Nenhuma || Sabor_Pizza != "" || qntd_Pizza > 0)
            {
                return true;
            }

            foreach (var adicional in Adicionais_Pedidos)
            {
                if (adicional != null)
                {
                    return true;
                }
            }

            return false;
        }

        private void atualizarTitulo()
        {
            Text = UsuarioLogado != null ? "Pedido - " + UsuarioLogado.Nome : "Pedido - Convidado";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja realmente limpar tudo? O estado atual do pedido será perdido.", "Limpar pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); 
            if (resposta == DialogResult.Yes)
            {
                limparPedido();
            }
        }

        private void limparPedido()
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            comboBox8.SelectedIndex = -1;
            comboBox9.SelectedIndex = -1;
            comboBox11.SelectedIndex = -1;
            comboBox12.SelectedIndex = -1;
            comboBox13.SelectedIndex = -1;
            comboBox14.SelectedIndex = -1;
            comboBox15.SelectedIndex = -1;
            comboBox16.SelectedIndex = -1;
            comboBox17.SelectedIndex = -1;
            comboBox18.SelectedIndex = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            listBox1.SelectedIndex = -1;
            pizzas.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;

            Sabor_Pizza = "";
            Sabor_Pizza_Preco = 0.0;
            Forma_de_Pagamento = FormaPagamento.Nenhuma;
            qntd_Pizza = 0;
            for (int i = 0; i < Adicionais_Pedidos.Length; i++) { Adicionais_Pedidos[i] = null; }
            for (int i = 0; i < Pedido_Acomp.Length; i++) { Pedido_Acomp[i] = null; Pedido_Acomp_Qntd[i] = 0; }
            for (int i = 0; i < Pedido_Bebidas.Length; i++) { Pedido_Bebidas[i] = null; Pedido_Bebidas_Qntd[i] = 0; }

            display();
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e) { Pedido_Bebidas_Qntd[0] = comboBox11.SelectedIndex + 1; display(); }
        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e) { Pedido_Bebidas_Qntd[1] = comboBox12.SelectedIndex + 1; display(); }
        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e) { Pedido_Bebidas_Qntd[2] = comboBox13.SelectedIndex + 1; display(); }
        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e) { Pedido_Bebidas_Qntd[3] = comboBox14.SelectedIndex + 1; display(); }
        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e) { Pedido_Bebidas_Qntd[4] = comboBox15.SelectedIndex + 1; display(); }
        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e) { Pedido_Bebidas_Qntd[5] = comboBox18.SelectedIndex + 1; display(); }
        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e) { Pedido_Bebidas_Qntd[6] = comboBox17.SelectedIndex + 1; display(); }
        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e) { Pedido_Bebidas_Qntd[7] = comboBox16.SelectedIndex + 1; display(); }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { Pedido_Acomp_Qntd[0] = comboBox2.SelectedIndex + 1; display(); }
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e) { Pedido_Acomp_Qntd[1] = comboBox7.SelectedIndex + 1; display(); }
        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e) { Pedido_Acomp_Qntd[2] = comboBox8.SelectedIndex + 1; display(); }
        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e) { Pedido_Acomp_Qntd[3] = comboBox9.SelectedIndex + 1; display(); }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                Pedido_Bebidas[7] = Bebidas[7];
                comboBox16.Visible = true;
                comboBox16.SelectedIndex = 0;
            }
            else
            {
                Pedido_Bebidas[7] = null;
                comboBox16.Visible = false;
            }
            display();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
            {
                Pedido_Bebidas[6] = Bebidas[6];
                comboBox17.Visible = true;
                comboBox17.SelectedIndex = 0;
            }
            else
            {
                Pedido_Bebidas[6] = null;
                comboBox17.Visible = false;
            }
            display();
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
            {
                Pedido_Bebidas[5] = Bebidas[5];
                comboBox18.Visible = true;
                comboBox18.SelectedIndex = 0;
            }
            else
            {
                Pedido_Bebidas[5] = null;
                comboBox18.Visible = false;
            }
            display();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                Pedido_Bebidas[4] = Bebidas[4];
                comboBox15.Visible = true;
                comboBox15.SelectedIndex = 0;
            }
            else
            {
                Pedido_Bebidas[4] = null;
                comboBox15.Visible = false;
            }
            display();
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                Pedido_Bebidas[3] = Bebidas[3];
                comboBox14.Visible = true;
                comboBox14.SelectedIndex = 0;
            }
            else
            {
                Pedido_Bebidas[3] = null;
                comboBox14.Visible = false;
            }
            display();
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                Pedido_Bebidas[2] = Bebidas[2];
                comboBox13.Visible = true;
                comboBox13.SelectedIndex = 0;
            }
            else
            {
                Pedido_Bebidas[2] = null;
                comboBox13.Visible = false;
            }
            display();
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                Pedido_Bebidas[1] = Bebidas[1];
                comboBox12.Visible = true;
                comboBox12.SelectedIndex = 0;
            }
            else
            {
                Pedido_Bebidas[1] = null;
                comboBox12.Visible = false;
            }
            display();
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                Pedido_Bebidas[0] = Bebidas[0];
                comboBox11.Visible = true;
                comboBox11.SelectedIndex = 0;
            }
            else
            {
                Pedido_Bebidas[0] = null;
                comboBox11.Visible = false;
            }
            display();
        }





        private void checkBox1_CheckedChanged(object sender, EventArgs e) { if (checkBox1.Checked) { Adicionais_Pedidos[0] = Adicionais[0]; } else { Adicionais_Pedidos[0] = null; } display(); }
        private void checkBox2_CheckedChanged(object sender, EventArgs e) { if (checkBox2.Checked) { Adicionais_Pedidos[1] = Adicionais[1]; } else { Adicionais_Pedidos[1] = null; } display(); }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            listBox1.Items.Clear();
            foreach (string prato in pratos_principais)
            {
                listBox1.Items.Add(prato);
            }
            checkBox1.Text = Adicionais[0];
            checkBox2.Text = Adicionais[1];
            checkBox5.Text = Acompanhamentos[0];
            checkBox6.Text = Acompanhamentos[1];
            checkBox7.Text = Acompanhamentos[2];
            checkBox8.Text = Acompanhamentos[3];

            checkBox9.Text = Bebidas[0];
            checkBox10.Text = Bebidas[1];
            checkBox11.Text = Bebidas[2];
            checkBox12.Text = Bebidas[3];
            checkBox13.Text = Bebidas[4];
            checkBox14.Text = Bebidas[5];
            checkBox15.Text = Bebidas[7];
            checkBox16.Text = Bebidas[6];

            comboBox2.Visible = false;
            comboBox7.Visible = false;
            comboBox8.Visible = false;
            comboBox9.Visible = false;
            comboBox11.Visible = false;
            comboBox12.Visible = false;
            comboBox13.Visible = false;
            comboBox14.Visible = false;
            comboBox15.Visible = false;
            comboBox16.Visible = false;
            comboBox17.Visible = false;
            comboBox18.Visible = false;

            atualizarTitulo();
            display();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index >= 0)
            {
                Sabor_Pizza = pratos_principais[index];
                Sabor_Pizza_Preco = pratos_principais_preco[index];

                switch (Sabor_Pizza)
                {
                    case "Mussarela":
                        pictureBox1.Image = Properties.Resources.Mussarela;
                        break;

                    case "Calabresa":
                        pictureBox1.Image = Properties.Resources.Calabresa;
                        break;

                    case "Frango com Catupiry":
                        pictureBox1.Image = Properties.Resources.Frango_Catupiry;
                        break;

                    case "3 Queijos":
                        pictureBox1.Image = Properties.Resources._3_Queijos;
                        break;

                    case "Portuguesa":
                        pictureBox1.Image = Properties.Resources.Portuguesa;
                        break;

                    case "Napolitana":
                        pictureBox1.Image = Properties.Resources.Napolitana;
                        break;

                    case "Pepperoni":
                        pictureBox1.Image = Properties.Resources.Peperoni;
                        break;

                    case "Chocolate":
                        pictureBox1.Image = Properties.Resources.Chocolate;
                        break;

                    default:
                        pictureBox1.Image = null;
                        break;
                }

                display();
            }
            else
            {
                Sabor_Pizza = "";
                Sabor_Pizza_Preco = 0.0;
                pictureBox1.Image = null;
                display();
            }
        }


        private void display()
        {
            textBox2.Clear();

            if (Sabor_Pizza == "")
            {
                textBox2.Text = "Nenhuma pizza selecionada.";
            }
            else
            {
                double preco_add = 0;
                for (int i = 0; i < Adicionais_Pedidos.Length; i++)
                {
                    if (Adicionais_Pedidos[i] != null)
                    {
                        preco_add += Adicionais_Preco[i];
                    }
                }

                int qntdPizza = qntd_Pizza > 0 ? qntd_Pizza : 1;
                double total = qntdPizza * (Sabor_Pizza_Preco + preco_add);
                textBox2.Text = Sabor_Pizza + " (" + qntdPizza + "x) - R$ " + total.ToString("0.00");

                string adicionais = "";
                foreach (var adicional in Adicionais_Pedidos)
                {
                    if (adicional != null)
                    {
                        adicionais += (adicionais == "" ? "" : ", ") + adicional;
                    }
                }
                textBox2.Text += Environment.NewLine;
                textBox2.Text += "Adicionais: " + (adicionais == "" ? "(nenhum)" : adicionais);
            }

            double totalPedido = 0;
            int qntd = 0;

            textBox1.Clear();

            textBox1.Text += "Pizzas no Pedido:";
            textBox1.Text += Environment.NewLine;
            if (pizzas.Count == 0)
            {
                textBox1.Text += "    (nenhuma pizza adicionada)";
                textBox1.Text += Environment.NewLine;
            }
            foreach (PizzaPedido pizza in pizzas)
            {
                textBox1.Text += "    - " + pizza.ToString();
                textBox1.Text += Environment.NewLine;
                totalPedido += pizza.Total();
            }

            textBox1.Text += "Pastéis e Esfihas:";
            textBox1.Text += Environment.NewLine;
            int index = 0;
            foreach (var acompanhamento in Pedido_Acomp)
            {
                if (acompanhamento != null)
                {
                    qntd = Pedido_Acomp_Qntd[index] > 0 ? Pedido_Acomp_Qntd[index] : 1;
                    double subtotal = qntd * Acompanhamentos_preco[index];
                    textBox1.Text += "    - " + acompanhamento + " (Qntd. " + qntd + ") - R$ " + subtotal.ToString("0.00") + Environment.NewLine;
                    totalPedido += subtotal;
                }
                index++;
            }

            textBox1.Text += "Bebidas:";
            textBox1.Text += Environment.NewLine;
            index = 0;
            foreach (var bebida in Pedido_Bebidas)
            {
                if (bebida != null)
                {
                    qntd = Pedido_Bebidas_Qntd[index] > 0 ? Pedido_Bebidas_Qntd[index] : 1;
                    double subtotal = qntd * Bebidas_preco[index];
                    textBox1.Text += "    - " + bebida + " (Qntd. " + qntd + ") - R$ " + subtotal.ToString("0.00") + Environment.NewLine;
                    totalPedido += subtotal;
                }
                index++;
            }

            textBox1.Text += Environment.NewLine;
            textBox1.Text += "Forma de Pagamento: " + NomeFormaPagamento() + Environment.NewLine;

            double percentual = descontoPorValor(totalPedido);
            double desconto = totalPedido * percentual / 100.0;

            textBox1.Text += "Subtotal: R$ " + totalPedido.ToString("0.00") + Environment.NewLine;
            textBox1.Text += "Desconto (" + percentual.ToString("0") + "%): R$ " + desconto.ToString("0.00") + Environment.NewLine;
            textBox1.Text += "Total: R$ " + (totalPedido - desconto).ToString("0.00");
        }

        private bool pedidoVazio()
        {
            if (pizzas.Count > 0)
            {
                return false;
            }
            foreach (var acompanhamento in Pedido_Acomp)
            {
                if (acompanhamento != null)
                {
                    return false;
                }
            }
            foreach (var bebida in Pedido_Bebidas)
            {
                if (bebida != null)
                {
                    return false;
                }
            }
            return true;
        }

        private double totalPedido()
        {
            double total = 0;

            foreach (PizzaPedido pizza in pizzas)
            {
                total += pizza.Total();
            }

            int index = 0;
            foreach (var acompanhamento in Pedido_Acomp)
            {
                if (acompanhamento != null)
                {
                    int qntd = Pedido_Acomp_Qntd[index] > 0 ? Pedido_Acomp_Qntd[index] : 1;
                    total += qntd * Acompanhamentos_preco[index];
                }
                index++;
            }

            index = 0;
            foreach (var bebida in Pedido_Bebidas)
            {
                if (bebida != null)
                {
                    int qntd = Pedido_Bebidas_Qntd[index] > 0 ? Pedido_Bebidas_Qntd[index] : 1;
                    total += qntd * Bebidas_preco[index];
                }
                index++;
            }

            return total;
        }

        private double descontoPorValor(double subtotal)
        {
            if (subtotal >= 250.0)
            {
                return 10.0;
            }

            if (subtotal >= 100.0)
            {
                return 5.0;
            }

            return 0.0;
        }

        private string montarRecibo(double subtotal, double desconto, double total, int parcelas, string nome, string cpf, bool cupom)
        {
            string resumo = "Pedido" + Environment.NewLine;
            resumo += "Cliente: " + nome + Environment.NewLine;

            if (cpf != "")
            {
                resumo += "CPF na nota: " + cpf + Environment.NewLine;
            }

            foreach (PizzaPedido pizza in pizzas)
            {
                resumo += "Pizza: " + pizza.Descricao() + Environment.NewLine;
            }

            int index = 0;
            foreach (var acompanhamento in Pedido_Acomp)
            {
                if (acompanhamento != null)
                {
                    int qntd = Pedido_Acomp_Qntd[index] > 0 ? Pedido_Acomp_Qntd[index] : 1;
                    resumo += "Pastel/Esfiha: " + acompanhamento + " (" + qntd + "x) - R$ " + (qntd * Acompanhamentos_preco[index]).ToString("0.00") + Environment.NewLine;
                }
                index++;
            }

            index = 0;
            foreach (var bebida in Pedido_Bebidas)
            {
                if (bebida != null)
                {
                    int qntd = Pedido_Bebidas_Qntd[index] > 0 ? Pedido_Bebidas_Qntd[index] : 1;
                    resumo += "Bebida: " + bebida + " (" + qntd + "x) - R$ " + (qntd * Bebidas_preco[index]).ToString("0.00") + Environment.NewLine;
                }
                index++;
            }

            resumo += Environment.NewLine;
            resumo += "Subtotal: R$ " + subtotal.ToString("0.00") + Environment.NewLine;

            if (desconto > 0)
            {
                resumo += "Desconto: R$ " + desconto.ToString("0.00")
                    + " (" + (desconto / subtotal * 100).ToString("0") + "%"
                    + (cupom ? " - cupom" : "") + ")" + Environment.NewLine;
            }

            resumo += "Total: R$ " + total.ToString("0.00") + Environment.NewLine;
            resumo += "Forma de pagamento: " + DescreverPagamento(total, parcelas);

            return resumo;
        }

        private string NomeFormaPagamento()
        {
            switch (Forma_de_Pagamento)
            {
                case FormaPagamento.CartaoCredito:
                    return "Cartão de Credito";

                case FormaPagamento.CartaoDebito:
                    return "Cartão de Debito";

                case FormaPagamento.Dinheiro:
                    return "Dinheiro";

                case FormaPagamento.Pix:
                    return "Pix";

                default:
                    return "";
            }
        }

        private string DescreverPagamento(double total, int parcelas)
        {
            string nome = NomeFormaPagamento();

            if (Forma_de_Pagamento == FormaPagamento.CartaoCredito)
            {
                return nome + " (" + parcelas + "x de R$ " + (total / parcelas).ToString("0.00") + ")";
            }

            return nome;
        }

        private void radioButtonPagamento_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton opcao = (RadioButton) sender;

            if (!opcao.Checked)
            {
                return;
            }

            switch (opcao.Name)
            {
                case "radioButton1":
                    Forma_de_Pagamento = FormaPagamento.CartaoCredito;
                    break;

                case "radioButton2":
                    Forma_de_Pagamento = FormaPagamento.CartaoDebito;
                    break;

                case "radioButton3":
                    Forma_de_Pagamento = FormaPagamento.Dinheiro;
                    break;

                case "radioButton4":
                    Forma_de_Pagamento = FormaPagamento.Pix;
                    break;

                default:
                    Forma_de_Pagamento = FormaPagamento.Nenhuma;
                    break;
            }

            display();
        }

        private bool obterDadosCliente(out string nome, out string cpf)
        {
            if (UsuarioLogado != null)
            {
                nome = UsuarioLogado.Nome;
                cpf = UsuarioLogado.Cpf;
                return true;
            }

            ClienteForm cliente = new ClienteForm();

            if (cliente.ShowDialog(this) != DialogResult.OK)
            {
                nome = "";
                cpf = "";
                return false;
            }

            nome = cliente.Nome;
            cpf = cliente.Cpf;
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pedidoVazio())
            {
                MessageBox.Show("Adicione pelo menos um item ao pedido (pizza, pastel/esfiha ou bebida) antes de concluir.", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Forma_de_Pagamento == FormaPagamento.Nenhuma)
            {
                MessageBox.Show("Selecione a forma de pagamento antes de concluir o pedido.", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nomeCliente;
            string cpfNota;

            if (!obterDadosCliente(out nomeCliente, out cpfNota))
            {
                return;
            }

            double subtotal = totalPedido();
            double percentual = descontoPorValor(subtotal);
            bool cupom = false;

            if (percentual < 10.0 && cpfNota != "" && PedidoStore.TemCupom(cpfNota))
            {
                double totalComCupom = subtotal * 0.90;

                DialogResult usarCupom = MessageBox.Show(
                    "Você tem um cupom de 10% de desconto!"
                    + Environment.NewLine + Environment.NewLine
                    + "Subtotal: R$ " + subtotal.ToString("0.00") + Environment.NewLine
                    + "Com o cupom: R$ " + totalComCupom.ToString("0.00")
                    + Environment.NewLine + Environment.NewLine
                    + "Deseja usar o cupom neste pedido?",
                    "Cupom de desconto",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (usarCupom == DialogResult.Yes)
                {
                    percentual = 10.0;
                    cupom = true;
                }
            }

            double desconto = subtotal * percentual / 100.0;
            double total = subtotal - desconto;

            DialogResult confirmacao = MessageBox.Show(
                "Subtotal: R$ " + subtotal.ToString("0.00") + Environment.NewLine
                + "Desconto: R$ " + desconto.ToString("0.00") + " (" + percentual.ToString("0") + "%)" + Environment.NewLine
                + "Total: R$ " + total.ToString("0.00")
                + Environment.NewLine + Environment.NewLine
                + "Tem certeza que deseja concluir o pedido?",
                "Concluir pedido",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacao != DialogResult.Yes)
            {
                return;
            }

            int parcelas = 1;

            switch (Forma_de_Pagamento)
            {
                case FormaPagamento.CartaoCredito:
                    ParcelamentoForm parcelamento = new ParcelamentoForm(total);

                    if (parcelamento.ShowDialog(this) != DialogResult.OK)
                    {
                        return;
                    }

                    parcelas = parcelamento.Parcelas;
                    break;

                case FormaPagamento.CartaoDebito:
                case FormaPagamento.Dinheiro:
                case FormaPagamento.Pix:
                    parcelas = 1;
                    break;
            }

            string recibo = montarRecibo(subtotal, desconto, total, parcelas, nomeCliente, cpfNota, cupom);

            string descricaoPagamento = DescreverPagamento(total, parcelas);

            RegistroPedido registro = new RegistroPedido();
            registro.Data = DateTime.Now;
            registro.Nome = nomeCliente;
            registro.Cpf = cpfNota;
            registro.Pagamento = descricaoPagamento;
            registro.Subtotal = subtotal;
            registro.Desconto = desconto;
            registro.Cupom = cupom;
            registro.Total = total;
            registro.Itens = recibo;
            PedidoStore.Salvar(registro);

            ConclusaoForm conclusao = new ConclusaoForm(recibo);

            if (conclusao.ShowDialog(this) == DialogResult.Yes)
            {
                limparPedido();
            }
            else
            {
                Application.Exit();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            qntd_Pizza = comboBox1.SelectedIndex + 1;
            display();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Sabor_Pizza == "")
            {
                MessageBox.Show("Selecione o sabor da pizza antes de adicionar ao pedido.", "Pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PizzaPedido pizza = new PizzaPedido();
            pizza.Sabor = Sabor_Pizza;
            pizza.Quantidade = qntd_Pizza > 0 ? qntd_Pizza : 1;
            pizza.PrecoUnitario = Sabor_Pizza_Preco;
            for (int i = 0; i < Adicionais_Pedidos.Length; i++)
            {
                if (Adicionais_Pedidos[i] != null)
                {
                    pizza.Adicionais.Add(Adicionais_Pedidos[i]);
                    pizza.AdicionaisPrecos.Add(Adicionais_Preco[i]);
                }
            }

            pizzas.Add(pizza);

            checkBox1.Checked = false;
            checkBox2.Checked = false;

            display();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DescontosForm descontos = new DescontosForm();
            descontos.ShowDialog(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pizzas.Count == 0)
            {
                MessageBox.Show("Não há pizzas no pedido para remover.", "Remover pizza", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            RemoverPizzaForm dialogo = new RemoverPizzaForm(pizzas);

            if (dialogo.ShowDialog(this) == DialogResult.OK)
            {
                pizzas.RemoveAt(dialogo.IndiceSelecionado);
                display();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                Pedido_Acomp[0] = Acompanhamentos[0];
                comboBox2.Visible = true;
                comboBox2.SelectedIndex = 0;
            }
            else
            {
                Pedido_Acomp[0] = null;
                comboBox2.Visible = false;
            }
            display();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                Pedido_Acomp[1] = Acompanhamentos[1];
                comboBox7.Visible = true;
                comboBox7.SelectedIndex = 0;
            }
            else
            {
                Pedido_Acomp[1] = null;
                comboBox7.Visible = false;
            }
            display();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                Pedido_Acomp[2] = Acompanhamentos[2];
                comboBox8.Visible = true;
                comboBox8.SelectedIndex = 0;
            }
            else
            {
                Pedido_Acomp[2] = null;
                comboBox8.Visible = false;
            }
            display();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                Pedido_Acomp[3] = Acompanhamentos[3];
                comboBox9.Visible = true;
                comboBox9.SelectedIndex = 0;
            }
            else
            {
                Pedido_Acomp[3] = null;
                comboBox9.Visible = false;
            }
            display();
        }
    }

    public class PizzaPedido
    {
        public string Sabor;
        public int Quantidade;
        public double PrecoUnitario;
        public List<string> Adicionais = new List<string>();
        public List<double> AdicionaisPrecos = new List<double>();

        public double PrecoAdicionais()
        {
            double total = 0;
            foreach (double preco in AdicionaisPrecos)
            {
                total += preco;
            }
            return total;
        }

        public double Total()
        {
            return Quantidade * (PrecoUnitario + PrecoAdicionais());
        }

        public string Descricao()
        {
            string texto = Quantidade + "x " + Sabor + " - R$ " + (Quantidade * PrecoUnitario).ToString("0.00");
            if (Adicionais.Count > 0)
            {
                texto += Environment.NewLine;
                texto += "        Adicionais: " + string.Join(", ", Adicionais) + " - R$ " + (Quantidade * PrecoAdicionais()).ToString("0.00");
            }
            return texto;
        }

        public override string ToString()
        {
            string texto = Quantidade + "x " + Sabor;
            if (Adicionais.Count > 0)
            {
                texto += " (" + string.Join(", ", Adicionais) + ")";
            }
            texto += " - R$ " + Total().ToString("0.00");
            return texto;
        }
    }
}
