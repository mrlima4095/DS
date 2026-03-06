using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc2
{
    public partial class Form1 : Form
    {
        public string signal = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            resultadoBox.Text = "";
        }


        private void button4_Click(object sender, EventArgs e)
        {
            int[] nums = get_numbers();
            resultadoBox.Text = nums[0] + " + " + nums[1] + " = " + (nums[0] + nums[1]);
        } 
        private void button5_Click(object sender, EventArgs e)
        {
            int[] nums = get_numbers();
            resultadoBox.Text = nums[0] + " - " + nums[1] + " = " + (nums[0] - nums[1]);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            int[] nums = get_numbers();
            resultadoBox.Text = nums[0] + " * " + nums[1] + " = " + (nums[0] * nums[1]);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            int[] nums = get_numbers();
            if (nums[0] == 0 || nums[1] == 0)
            {
                resultadoBox.Text = "ERRO!!! Impossivel dividir por zero.";
                return;
            }
            resultadoBox.Text = nums[0] + " / " + nums[1] + " = " + (nums[0] / nums[1]);
        }

        private int[] get_numbers()
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                return new int[] { 0, 0 };
            }
            int num1, num2;
            num1 = Convert.ToInt32(textBox1.Text);
            num2 = Convert.ToInt32(textBox2.Text);
            return new int[] { num1, num2 };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
