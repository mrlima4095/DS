using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_1___Felipe
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ex1_choiceBtn_Click(object sender, EventArgs e)
        {
            ex1 Exercicio1 = new ex1();
            Exercicio1.Show();
        }

        private void ex2_choiceBtn_Click(object sender, EventArgs e)
        {
            ex2 Exercicio2 = new ex2();
            Exercicio2.Show();
        }

        private void ex21_choiceBtn_Click(object sender, EventArgs e)
        {
            ex21 Exercicio21 = new ex21();
            Exercicio21.Show();
        }

        private void ex3_choiceBtn_Click(object sender, EventArgs e)
        {
            ex3 Exercicio3 = new ex3();
            Exercicio3.Show();
        }

        private void ex4_choiceBtn_Click(object sender, EventArgs e)
        {
            ex4 Exercicio4 = new ex4();
            Exercicio4.Show();
        }

        private void ex5_choiceBtn_Click(object sender, EventArgs e)
        {
            ex5 Exercicio5 = new ex5();
            Exercicio5.Show();
        }

        private void ex6_choiceBtn_Click(object sender, EventArgs e)
        {
            ex6 Exercicio6 = new ex6();
            Exercicio6.Show();
        }

        private void ex7_choiceBtn_Click(object sender, EventArgs e)
        {
            //ex7 Exercicio7 = new ex7();
            //Exercicio7.Show();
        }

    }
}