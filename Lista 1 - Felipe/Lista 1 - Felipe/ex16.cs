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

namespace Lista_1___Felipe
{
    public partial class ex16 : Form
    {
        public ex16()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e) { textBox1.Text = ""; result_textBox.Text = ""; }
        private void exitBtn_Click(object sender, EventArgs e) { this.Close(); }

        private void fireBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                result_textBox.Text = "Preencha todos os campos deste formulario para realizar a operação!";
            }

            double speed = Convert.ToDouble(textBox1.Text);
            result_textBox.Text = speed + " km/h = " + (speed / 3.6).ToString("F2") + " m/s";
        }
    }
}