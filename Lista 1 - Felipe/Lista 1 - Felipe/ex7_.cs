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
    public partial class ex7 : Form
    {
        public ex7()
        {
            InitializeComponent();
        }

        private void fireBtn_example(object sender, EventArgs e)
        {
        }
        private void clearBtn_Click(object sender, EventArgs e) { textBox1.Text = ""; textBox2.Text = ""; result_textBox.Text = ""; }
        private void exitBtn_Click(object sender, EventArgs e) { this.Close(); }

        private void fireBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text))
            {
                result_textBox.Text = "Preencha todos os campos deste formulario para realizar a operação!";
            }

            double tempo = Convert.ToDouble(textBox1.Text), velocidade = Convert.ToDouble(textBox2.Text);
            double distancia = tempo * velocidade, litros_usados = distancia / 12;

            result_textBox.Text = "Velocidade Média: " + velocidade.ToString("F2") + " km/h" + Environment.NewLine + "Tempo Gasto: " + tempo.ToString("F2") + " horas" + Environment.NewLine + "Distância: " + distancia.ToString("F2") + " km" + Environment.NewLine + "Litros Usados: " + litros_usados.ToString("F2");
        }
    }
}