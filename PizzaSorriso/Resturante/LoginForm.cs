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
    public partial class LoginForm : Form
    {
        public Conta Usuario { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cpf = ContaStore.SomenteDigitos(textBox1.Text);

            if (!ContaStore.CpfValido(cpf))
            {
                MessageBox.Show("Digite um CPF válido para entrar.", "Pizzaria Sorriso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                textBox1.SelectAll();
                return;
            }

            Conta conta = ContaStore.BuscarPorCpf(cpf);

            if (conta == null)
            {
                MessageBox.Show("Esse CPF não está cadastrado. Crie uma conta ou entre como convidado.", "Pizzaria Sorriso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Focus();
                textBox1.SelectAll();
                return;
            }

            if (conta.Senha != textBox2.Text)
            {
                MessageBox.Show("Senha incorreta.", "Pizzaria Sorriso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Clear();
                textBox2.Focus();
                return;
            }

            Usuario = conta;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastroForm cadastro = new CadastroForm();

            if (cadastro.ShowDialog(this) == DialogResult.OK)
            {
                Usuario = cadastro.ContaCadastrada;
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Usuario = null;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DescontosForm desc = new DescontosForm();
            desc.Show();
        }
    }
}
