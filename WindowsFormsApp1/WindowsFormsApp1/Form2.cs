using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade = Int32.Parse(textBox1.Text);
            double altura = Convert.ToDouble(textBox2.Text);

            if ((idade >= 15) && (idade <= 25) && (altura >= 1.60))
            {
                textBox3.AppendText("Sim" + Environment.NewLine + "Pode entrar para a equipe de natação!"); 
            }
            else
            {
                textBox3.AppendText("Não pode entrar na equipe de natação!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
