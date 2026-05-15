using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes_PICTUREBOX
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pictureBox1.Image = Properties.Resources.images;
            } else
            {
                pictureBox1.Image = null;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked)
            {
                pictureBox2.Image = Properties.Resources.Csharp_Logo;
            }
            else
            {
                pictureBox2.Image = null;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox3.Checked)
            {
                pictureBox3.Image = Properties.Resources.Python_logo;
            }
            else
            {
                pictureBox3.Image = null;
            }
        }
    }
}
