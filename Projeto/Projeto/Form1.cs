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

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hide(int level)
        {
            if (level <= 2)
            {
                checkBox1.Visible = false;
                checkBox1.Checked = false;
                checkBox2.Visible = false;
                checkBox2.Checked = false;
                checkBox3.Visible = false;
                checkBox3.Checked = false;
                if (level <= 1)
                {
                    radioButton1.Visible = false;
                    radioButton1.Checked = false;
                    radioButton2.Visible = false;
                    radioButton2.Checked = false;
                    radioButton3.Visible = false;
                    radioButton3.Checked = false;
                    if (level == 0)
                    {
                        comboBox1.Items.Clear();
                    }
                }
            }

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
            hide(1);
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
            else if (listBox1.SelectedIndex == 2)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    radioButton1.Visible = true;
                    radioButton1.Text = "Representação";
                    radioButton2.Visible = true;
                    radioButton2.Text = "Cores";
                    radioButton3.Visible = true;
                    radioButton3.Text = "Medindo Aura";
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    radioButton1.Visible = true;
                    radioButton1.Text = "Tarot";
                    radioButton2.Visible = true;
                    radioButton2.Text = "Baralho Cigano";
                    radioButton3.Visible = true;
                    radioButton3.Text = "Bola de Cristal";
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    radioButton1.Visible = true;
                    radioButton1.Text = "Ars Goetia";
                    radioButton2.Visible = true;
                    radioButton2.Text = "Encantamentos";
                    radioButton3.Visible = true;
                    radioButton3.Text = "Itens";
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    radioButton1.Visible = true;
                    radioButton1.Text = "Idade Media";
                    radioButton2.Visible = true;
                    radioButton2.Text = "Rituais";
                    radioButton3.Visible = true;
                    radioButton3.Text = "Exemplos";
                }
            }
            else if (listBox1.SelectedIndex == 3)
            {
                radioButton1.Visible = true;
                radioButton1.Text = "Representações";
                radioButton2.Visible = true;
                radioButton2.Text = "Lendas";
                radioButton3.Visible = true;
                radioButton3.Text = "Fontes";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Fotos";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Mapas";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Relevo";
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Pinturas";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Representações";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Teorias";
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    if (radioButton2.Checked == true)
                    {
                        checkBox1.Visible = true;
                        checkBox1.Text = "Pintura";
                        checkBox2.Visible = true;
                        checkBox2.Text = "Representações";
                        checkBox3.Visible = true;
                        checkBox3.Text = "Canoeiro";
                    }
                    else if (radioButton2.Checked == true)
                    {
                        checkBox1.Visible = true;
                        checkBox1.Text = "Pintura";
                        checkBox2.Visible = true;
                        checkBox2.Text = "Representações";
                        checkBox3.Visible = true;
                        checkBox3.Text = "Canoeiro";
                    }
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Pinturas";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Irkalla";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Lendas";
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "3 Sois";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Astros";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Eclipse";
                }

            }
        }

    }
}
