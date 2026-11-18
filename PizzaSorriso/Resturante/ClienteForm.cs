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
    public partial class ClienteForm : Form
    {
        public string Nome { get; private set; }

        public string Cpf { get; private set; }

        public ClienteForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text.Trim();

            if (nome.Length < 2)
            {
                MessageBox.Show("Informe o nome do cliente para a nota.", "Cliente do pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            string cpf = ContaStore.SomenteDigitos(textBox2.Text);

            if (cpf != "" && !ContaStore.CpfValido(cpf))
            {
                MessageBox.Show("Esse CPF não é válido. Deixe em branco se não quiser o CPF na nota.", "Cliente do pedido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                textBox2.SelectAll();
                return;
            }

            Nome = nome;
            Cpf = cpf;

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
