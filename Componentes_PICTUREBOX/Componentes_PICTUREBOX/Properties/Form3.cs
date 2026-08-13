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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked) checkBox1.BackColor = Color.Pink; else checkBox1.BackColor = Color.WhiteSmoke;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) checkBox2.BackColor = Color.Cyan; else checkBox2.BackColor = Color.WhiteSmoke;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) checkBox3.BackColor = Color.Brown; else checkBox3.BackColor = Color.WhiteSmoke;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) checkBox4.BackColor = Color.Yellow; else checkBox4.BackColor = Color.WhiteSmoke;
        }
    }
}
