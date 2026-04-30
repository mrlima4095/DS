using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int day = Convert.ToInt32(textBox1.Text);
                switch (day)
                {
                    case 1:
                        textBox2.Text = "Monday";
                        break;
                    case 2:
                        textBox2.Text = "Tuesday";
                        break;
                    case 3:
                        textBox2.Text = "";
                        break;
                    case 4:
                        textBox2.Text = "";
                        break;
                    case 5:
                        textBox2.Text = "";
                        break;
                    case 6:
                        textBox2.Text = "";
                        break;
                    case 7:
                        textBox2.Text = "";
                        break;

                    default:
                        textBox2.Text = "Este mês não existe.... LMAO!";
                        break;
                }
            } catch
            {
                MessageBox.Show("Tente Novamente!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
