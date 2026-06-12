using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hide(int level)
        {
            comboBox1.Items.Clear();
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                hide(0);
                comboBox1.Items.Add("Cosmologia Biblica");
                comboBox1.Items.Add("Cosmologia Babilonica");
                comboBox1.Items.Add("Cosmologia Sumeria");
                comboBox1.Items.Add("Cosmologia Egipicia");
                comboBox1.SelectedIndex = 0;
            } 
            else if (listBox1.SelectedIndex == 1)
            {
                hide(0);
                comboBox1.Items.Add("Maçonaria");
                comboBox1.Items.Add("Illuminatis");
                comboBox1.Items.Add("Skull and Bones");
                comboBox1.Items.Add("Rosa Cruz");
                comboBox1.SelectedIndex = 0;

            } 
            else if (listBox1.SelectedIndex == 2)
            {
                hide(0);
                comboBox1.Items.Add("Auras");
                comboBox1.Items.Add("Oraculos");
                comboBox1.Items.Add("Magia Cerimonial");
                comboBox1.Items.Add("Necromancia");
                comboBox1.SelectedIndex = 0;
            } 
            else if (listBox1.SelectedIndex == 3)
            {
                hide(0);
                comboBox1.Items.Add("Lança do Destino");
                comboBox1.Items.Add("Santo Graal");
                comboBox1.Items.Add("Arca da Aliança");
                comboBox1.Items.Add("Anel de Salomão");
                comboBox1.SelectedIndex = 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    radioButton1.Visible = true;
                    radioButton1.Text = "Superficie";
                    radioButton2.Visible = true;
                    radioButton2.Text = "Sheol (Inferno)";
                    radioButton3.Visible = true;
                    radioButton3.Text = "Céus e Astros";
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    radioButton1.Visible = true;
                    radioButton1.Text = "Mundo Superior";
                    radioButton2.Visible = true;
                    radioButton2.Text = "Mundo Inferior";
                    radioButton3.Visible = true;
                    radioButton3.Text = "Os Céus";
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    radioButton1.Visible = true;
                    radioButton1.Text = "Ki (Mundo Superior)";
                    radioButton2.Visible = true;
                    radioButton2.Text = "Apsu (Submundo)";
                    radioButton3.Visible = true;
                    radioButton3.Text = "Os Céus";
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    radioButton1.Visible = true;
                    radioButton1.Text = "Terra";
                    radioButton2.Visible = true;
                    radioButton2.Text = "Mundo Inferior";
                    radioButton3.Visible = true;
                    radioButton3.Text = "Céus e Astros";
                }
            }
            else if (listBox1.SelectedIndex == 1)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    radioButton1.Visible = true;
                    radioButton1.Text = "Loja Maçonica";
                    radioButton2.Visible = true;
                    radioButton2.Text = "Roupas";
                    radioButton3.Visible = true;
                    radioButton3.Text = "Jachin e Boaz";
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    radioButton1.Visible = true;
                    radioButton1.Text = "Simbolo";
                    radioButton2.Visible = true;
                    radioButton2.Text = "Nota de dólar";
                    radioButton3.Visible = true;
                    radioButton3.Text = "Olho que tudo vê";
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    radioButton1.Visible = true;
                    radioButton1.Text = "Logo";
                    radioButton2.Visible = true;
                    radioButton2.Text = "Templo";
                    radioButton3.Visible = true;
                    radioButton3.Text = "Membros";
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    radioButton1.Visible = true;
                    radioButton1.Text = "Logo";
                    radioButton2.Visible = true;
                    radioButton2.Text = "Templo";
                    radioButton3.Visible = true;
                    radioButton3.Text = "Ordem Cabalistica";
                }
            }
        }
    }
}
