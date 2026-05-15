using Componentes_PICTUREBOX.Properties;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.istockphoto_98013994_612x612;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._610VuYNv4KL__AC_UF894_1000_QL80_;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.nas;
        }
    }
}
