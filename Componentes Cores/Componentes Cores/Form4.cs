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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                this.BackColor = Color.Gray;
            }
            else if (listBox1.SelectedIndex == 1)
            {
                this.BackColor = Color.Orange;

            }
            else if (listBox1.SelectedIndex == 2)
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
