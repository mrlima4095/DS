using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
        public int N_MESA = 1;
        public int N_PESSOAS = 1;
        public string Prato_Principal = "";
        public string Forma_de_Pagamento = "";
        public string[] Pedido_Acomp = new string[8] { null, null, null, null, null, null, null, null };
        public int[] Pedido_Acomp_Qntd = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
        public string[] Pedido_Bebidas = new string[8] { null, null, null, null, null, null, null, null };
        public int[] Pedido_Bebidas_Qntd = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };

        public string[] Acompanhamentos = { "Batata", "Salada", "A", "B", "C", "D", "E", "F" };
        public double[] Acompanhamentos_preco = { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };
        public string[] Bebidas = { "Agua", "Suco", "Sucada", "Asucada", "A", "B", "C", "D" };
        public double[] Bebidas_preco = { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };
        public string[] pratos_principais = { "Prato 1", "Arroz 2", "Prato 3", "Prato 4", "Prato 5", "Prato 6", "Prato 7", "Prato 8" };
        public double[] pratos_principais_preco = { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };
        public CheckBox[] checkBoxes = new CheckBox[20];
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            comboBox8.SelectedIndex = -1;
            comboBox9.SelectedIndex = -1;
            comboBox10.SelectedIndex = -1;
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
            listBox1.SelectedIndex = -1;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) { Pedido_Acomp_Qntd[0] = comboBox3.SelectedIndex + 1; display(); }
        private void comboBox4_SelectedIndexChanged_1(object sender, EventArgs e) { Pedido_Acomp_Qntd[1] = comboBox4.SelectedIndex + 1; display(); }
        private void comboBox5_SelectedIndexChanged_1(object sender, EventArgs e) { Pedido_Acomp_Qntd[2] = comboBox5.SelectedIndex + 1; display(); }
        private void comboBox6_SelectedIndexChanged_1(object sender, EventArgs e) { Pedido_Acomp_Qntd[3] = comboBox6.SelectedIndex + 1; display(); }
        private void comboBox7_SelectedIndexChanged_1(object sender, EventArgs e) { Pedido_Acomp_Qntd[4] = comboBox7.SelectedIndex + 1; display(); }
        private void comboBox8_SelectedIndexChanged_1(object sender, EventArgs e) { Pedido_Acomp_Qntd[5] = comboBox8.SelectedIndex + 1; display(); }
        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e) { Pedido_Acomp_Qntd[6] = comboBox9.SelectedIndex + 1; display(); }
        private void comboBox10_SelectedIndexChanged_1(object sender, EventArgs e) { Pedido_Acomp_Qntd[7] = comboBox10.SelectedIndex + 1; display(); }




        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { Pedido_Acomp[0] = Acompanhamentos[0]; }
            else { Pedido_Acomp[0] = null; }
            display();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) { Pedido_Acomp[2] = Acompanhamentos[2]; }
            else { Pedido_Acomp[2] = null; }
            display();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) { Pedido_Acomp[3] = Acompanhamentos[3]; }
            else { Pedido_Acomp[3] = null; }
            display();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked) { Pedido_Acomp[4] = Acompanhamentos[4]; }
            else { Pedido_Acomp[4] = null; }
            display();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked) { Pedido_Acomp[5] = Acompanhamentos[5]; }
            else { Pedido_Acomp[5] = null; }
            display();
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked) { Pedido_Acomp[6] = Acompanhamentos[6]; }
            else { Pedido_Acomp[6] = null; }
            display();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked) { Pedido_Acomp[7] = Acompanhamentos[7]; }
            else { Pedido_Acomp[7] = null; }
            display();
        }




        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) { Pedido_Acomp[1] = Acompanhamentos[1]; }
            else { Pedido_Acomp[1] = null; }
            display();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            N_MESA = comboBox1.SelectedIndex + 1;
            display();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            N_PESSOAS = comboBox2.SelectedIndex + 1;
            display();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) 
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            listBox1.Items.Clear();
            foreach (string prato in pratos_principais)
            {
                listBox1.Items.Add(prato);
            }
            checkBox1.Text = Acompanhamentos[0];
            checkBox2.Text = Acompanhamentos[1];
            checkBox3.Text = Acompanhamentos[2];
            checkBox4.Text = Acompanhamentos[3];
            checkBox5.Text = Acompanhamentos[4];
            checkBox6.Text = Acompanhamentos[5];
            checkBox7.Text = Acompanhamentos[6];
            checkBox8.Text = Acompanhamentos[7];

            checkBox9.Text = Bebidas[0];
            checkBox10.Text = Bebidas[1];
            checkBox11.Text = Bebidas[2];
            checkBox12.Text = Bebidas[3];
            checkBox13.Text = Bebidas[4];
            checkBox14.Text = Bebidas[5];
            checkBox15.Text = Bebidas[6];
            checkBox16.Text = Bebidas[7];
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Prato_Principal = pratos_principais[listBox1.SelectedIndex];
            display();
        }


        private void display()
        {
            textBox1.Clear();
            textBox1.Text = "Pedido #1";
            textBox1.Text += Environment.NewLine;
            textBox1.Text += Environment.NewLine;
            textBox1.Text += "Mesa Solicitada: " + N_MESA;
            textBox1.Text += Environment.NewLine;
            textBox1.Text += "Número de Pessoas: " + N_PESSOAS;
            textBox1.Text += Environment.NewLine;
            textBox1.Text += "-----";
            textBox1.Text += Environment.NewLine;
            textBox1.Text += "Prato Principal: " + Prato_Principal;
            textBox1.Text += Environment.NewLine;
            textBox1.Text += "Acompanhamentos:";
            textBox1.Text += Environment.NewLine;
            int index = 0;
            foreach (var acompanhamento in Pedido_Acomp)
            {
                if (acompanhamento != null)
                {
                    textBox1.Text += "    - " + acompanhamento + " (Qntd. " + Pedido_Acomp_Qntd[index] + ")" + Environment.NewLine;
                }
                index++;
            }  
            textBox1.Text += Environment.NewLine;
            textBox1.Text += "Bebidas:";
            textBox1.Text += Environment.NewLine;
            index = 0;
            foreach (var bebida in Pedido_Bebidas)
            {
                if (bebida != null)
                {
                    textBox1.Text += "    - " + bebida + " (Qntd. " + Pedido_Bebidas_Qntd[index] + ")" + Environment.NewLine;
                }
                index++;
            }
            textBox1.Text += Environment.NewLine;
            textBox1.Text += "Forma de Pagamento: " + Forma_de_Pagamento;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) { Forma_de_Pagamento = "Cartão de Credito"; display(); }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { Forma_de_Pagamento = "Cartão de Debito"; display(); }
        private void radioButton3_CheckedChanged(object sender, EventArgs e) { Forma_de_Pagamento = "Dinheiro"; display(); }


    }
}
