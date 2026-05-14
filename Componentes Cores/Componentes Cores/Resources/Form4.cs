using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes_Cores
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cinza")
            {
                this.BackColor = Color.Gray;
            }
            else if (comboBox1.Text == "Laranja")
            {
                this.BackColor = Color.Orange;

            }
            else if (comboBox1.Text == "Verde")
            {
                this.BackColor = Color.LightGreen;

            }
            else
            {
                this.BackColor = Color.Pink;

            }
        }
    }
}
