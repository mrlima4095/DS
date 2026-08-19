using Projeto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splash_Screen
{
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.FormBorderStyle = FormBorderStyle.None;

            //timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1.Start();
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            progressBar1.PerformStep();
            label1.Text = "Carregando aplicação ... " + progressBar1.Value + " %";

        }
    }
}
