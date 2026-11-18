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
    public partial class SenhaForm : Form
    {
        public SenhaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1234")
            {
                DialogResult = DialogResult.OK;
                this.Close();
                return;
            }

            MessageBox.Show("Senha incorreta.", "Acesso restrito", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
