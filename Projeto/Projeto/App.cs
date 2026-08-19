using Projeto.Properties;
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
    public partial class App : Form
    {
        public App()
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
                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;

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
                comboBox1.SelectedIndex = 0;
            }
            else if (listBox1.SelectedIndex == 1)
            {
                hide(0);
                comboBox1.Items.Add("Ma�onaria");
                comboBox1.Items.Add("Illuminatis");
                comboBox1.SelectedIndex = 0;
            }
            else if (listBox1.SelectedIndex == 2)
            {
                hide(0);
                comboBox1.Items.Add("Auras");
                comboBox1.Items.Add("Oraculos");
                comboBox1.Items.Add("Magia Cerimonial");
                comboBox1.SelectedIndex = 0;
            }
            else if (listBox1.SelectedIndex == 3)
            {
                hide(0);
                comboBox1.Items.Add("Lança do Destino");
                comboBox1.Items.Add("Santo Graal");
                comboBox1.Items.Add("Arca da Alian�a");
                comboBox1.SelectedIndex = 0;
            }
            else if (listBox1.SelectedIndex == 4)
            {
                hide(0);
                comboBox1.Items.Add("Baal");
                comboBox1.Items.Add("Baphomet");
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
            }
            else if (listBox1.SelectedIndex == 1)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    radioButton1.Visible = true;
                    radioButton1.Text = "Loja Ma�onica";
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
                    radioButton2.Text = "Nota de d�lar";
                    radioButton3.Visible = true;
                    radioButton3.Text = "Olho que tudo v�";
                }
            }
            else if (listBox1.SelectedIndex == 2)
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    radioButton1.Visible = true;
                    radioButton1.Text = "Representa��o";
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
            }
            else if (listBox1.SelectedIndex == 3)
            {
                radioButton1.Visible = true;
                radioButton1.Text = "Representa��es";
                radioButton2.Visible = true;
                radioButton2.Text = "Lendas";
                radioButton3.Visible = true;
                radioButton3.Text = "Fontes";
            }
            else if (listBox1.SelectedIndex == 4)
            {
                radioButton1.Visible = true;
                radioButton1.Text = "Origem";
                radioButton2.Visible = true;
                radioButton2.Text = "Formas";
                radioButton3.Visible = true;
                radioButton3.Text = "Culto";
            }
        }

        // ================================================================
        //  RADIO 1
        // ================================================================
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton1.Checked) return;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

            // ============ LISTA 0: TERRA PLANA ============
            if (listBox1.SelectedIndex == 0)
            {
                // Terra Plana > Cosmologia Biblica > Superficie
                if (comboBox1.SelectedIndex == 0)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Fotos";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Mapas";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Relevo";
                }
            }
            // ============ LISTA 1: SOCIEDADES SECRETAS ============
            else if (listBox1.SelectedIndex == 1)
            {
                // Sociedades Secretas > Ma�onaria > Loja Ma�onica
                if (comboBox1.SelectedIndex == 0)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Estrutura";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Graus";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Rituais";
                }
                // Sociedades Secretas > Illuminatis > Simbolo
                else if (comboBox1.SelectedIndex == 1)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Piramide";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Olho";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Historia";
                }
            }
            // ============ LISTA 2: AURA & MAGIA ============
            else if (listBox1.SelectedIndex == 2)
            {
                // Aura & Magia > Auras > Representa��o
                if (comboBox1.SelectedIndex == 0)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Fotos";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Desenhos";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Cores";
                }
                // Aura & Magia > Oraculos > Tarot
                else if (comboBox1.SelectedIndex == 1)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Arcanos Maiores";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Arcanos Menores";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Leitura";
                }
                // Aura & Magia > Magia Cerimonial > Ars Goetia
                else if (comboBox1.SelectedIndex == 2)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Demonios";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Selos";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Invocações";
                }
            }
            // ============ LISTA 3: OBJETOS LENDARIOS ============
            else if (listBox1.SelectedIndex == 3)
            {
                // Objetos Lendarios > Lan�a do Destino > Representa��es
                if (comboBox1.SelectedIndex == 0)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Fotos";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Pinturas";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Réplicas";
                }
                // Objetos Lendarios > Santo Graal > Representa��es
                else if (comboBox1.SelectedIndex == 1)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Fotos";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Pinturas";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Réplicas";
                }
                // Objetos Lendarios > Arca da Alian�a > Representa��es
                else if (comboBox1.SelectedIndex == 2)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Fotos";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Pinturas";
                    checkBox3.Visible = true;
                    checkBox3.Text = "R�plicas";
                }
            }
            // ============ LISTA 4: FALSOS DEUSES ============
            else if (listBox1.SelectedIndex == 4)
            {
                // Falsos Deuses > Baal > Origem
                if (comboBox1.SelectedIndex == 0)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Cana�";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Mitologia";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Historia";
                }
                // Falsos Deuses > Baphomet > Origem
                else if (comboBox1.SelectedIndex == 1)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Templários";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Historia";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Acusações";
                }
            }
        }

        // ================================================================
        //  RADIO 2
        // ================================================================
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton2.Checked) return;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

            // ============ LISTA 0: TERRA PLANA ============
            if (listBox1.SelectedIndex == 0)
            {
                // Terra Plana > Cosmologia Biblica > Sheol (Inferno)
                if (comboBox1.SelectedIndex == 0)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Pintura";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Representações";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Canoeiro";
                }
            }
            // ============ LISTA 1: SOCIEDADES SECRETAS ============
            else if (listBox1.SelectedIndex == 1)
            {
                // Sociedades Secretas > Ma�onaria > Roupas
                if (comboBox1.SelectedIndex == 0)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Avental";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Colar";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Chap�u";
                }
                // Sociedades Secretas > Illuminatis > Nota de d�lar
                else if (comboBox1.SelectedIndex == 1)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Piramide";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Olho";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Simbologia";
                }
            }
            // ============ LISTA 2: AURA & MAGIA ============
            else if (listBox1.SelectedIndex == 2)
            {
                // Aura & Magia > Auras > Cores
                if (comboBox1.SelectedIndex == 0)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Vermelho";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Azul";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Verde";
                }
                // Aura & Magia > Oraculos > Baralho Cigano
                else if (comboBox1.SelectedIndex == 1)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Cartas";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Leitura";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Simbolos";
                }
                // Aura & Magia > Magia Cerimonial > Encantamentos
                else if (comboBox1.SelectedIndex == 2)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Feitiços";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Rituais";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Palavras";
                }
                // Aura & Magia > Necromancia > Rituais
                else if (comboBox1.SelectedIndex == 3)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Circulos";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Ofertas";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Cerimonias";
                }
            }
            // ============ LISTA 3: OBJETOS LENDARIOS ============
            else if (listBox1.SelectedIndex == 3)
            {
                // Objetos Lendarios > Lan�a do Destino > Lendas
                if (comboBox1.SelectedIndex == 0)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Historia";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Lendas";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Mitologia";
                }
                // Objetos Lendarios > Santo Graal > Lendas
                else if (comboBox1.SelectedIndex == 1)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Arturiana";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Busca";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Mitologia";
                }
                // Objetos Lendarios > Arca da Alian�a > Lendas
                else if (comboBox1.SelectedIndex == 2)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Historia";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Poderes";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Mitologia";
                }
            }
            // ============ LISTA 4: FALSOS DEUSES ============
            else if (listBox1.SelectedIndex == 4)
            {
                // Falsos Deuses > Baal > Formas
                if (comboBox1.SelectedIndex == 0)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Touro";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Representações";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Est�tuas";
                }
                // Falsos Deuses > Baphomet > Formas
                else if (comboBox1.SelectedIndex == 1)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Cabeça de Bode";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Representações";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Simbolos";
                }
            }
        }

        // ================================================================
        //  RADIO 3
        // ================================================================
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton3.Checked) return;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;

            // ============ LISTA 0: TERRA PLANA ============
            if (listBox1.SelectedIndex == 0)
            {
                // Terra Plana > Cosmologia Biblica > C�us e Astros
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
            // ============ LISTA 1: SOCIEDADES SECRETAS ============
            else if (listBox1.SelectedIndex == 1)
            {
                // Sociedades Secretas > Ma�onaria > Jachin e Boaz
                if (comboBox1.SelectedIndex == 0)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Colunas";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Significado";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Hist�ria";
                }
                // Sociedades Secretas > Illuminatis > Olho que tudo v�
                else if (comboBox1.SelectedIndex == 1)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Origem";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Significado";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Uso";
                }
            }
            // ============ LISTA 2: AURA & MAGIA ============
            else if (listBox1.SelectedIndex == 2)
            {
                // Aura & Magia > Auras > Medindo Aura
                if (comboBox1.SelectedIndex == 0)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Kirlian";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Fotografia";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Leitura";
                }
                // Aura & Magia > Oraculos > Bola de Cristal
                else if (comboBox1.SelectedIndex == 1)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Historia";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Leitura";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Uso";
                }
                // Aura & Magia > Magia Cerimonial > Itens
                else if (comboBox1.SelectedIndex == 2)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Varinha";
                    checkBox2.Visible = true;
                    checkBox2.Text = "C�rculo";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Incenso";
                }
                // Aura & Magia > Necromancia > Exemplos
                else if (comboBox1.SelectedIndex == 3)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Casos";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Famosos";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Lendas";
                }
            }
            // ============ LISTA 3: OBJETOS LENDARIOS ============
            else if (listBox1.SelectedIndex == 3)
            {
                // Objetos Lendarios > Lan�a do Destino > Fontes
                if (comboBox1.SelectedIndex == 0)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Livros";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Documentos";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Referencias";
                }
                // Objetos Lendarios > Santo Graal > Fontes
                else if (comboBox1.SelectedIndex == 1)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Livros";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Documentos";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Referencias";
                }
                // Objetos Lendarios > Arca da Alian�a > Fontes
                else if (comboBox1.SelectedIndex == 2)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Livros";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Documentos";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Referencias";
                }
            }
            // ============ LISTA 4: FALSOS DEUSES ============
            else if (listBox1.SelectedIndex == 4)
            {
                // Falsos Deuses > Baal > Culto
                if (comboBox1.SelectedIndex == 0)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Rituais";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Sacrificios";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Templos";
                }
                // Falsos Deuses > Baphomet > Culto
                else if (comboBox1.SelectedIndex == 1)
                {
                    checkBox1.Visible = true;
                    checkBox1.Text = "Rituais";
                    checkBox2.Visible = true;
                    checkBox2.Text = "Satanismo";
                    checkBox3.Visible = true;
                    checkBox3.Text = "Templos";
                }
            }
        }

        // ================================================================
        //  CHECKBOX 1
        // ================================================================
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkbox();
        }

        // ================================================================
        //  CHECKBOX 2
        // ================================================================
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkbox();
        }

        // ================================================================
        //  CHECKBOX 3
        // ================================================================
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkbox();
        }

        private void checkbox()
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;

            // ==========================================
            // LISTA 0: TERRA PLANA
            // ==========================================
            if (listBox1.SelectedIndex == 0)
            {
                // ==========================================
                // TERRA PLANA > COSMOLOGIA BIBLICA
                // ==========================================
                if (comboBox1.SelectedIndex == 0)
                {
                    if (radioButton1.Checked) // Superficie
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.Terra_Plana___Fotos;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.Terra_Plana___Mapa;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.Terra_Plana___Relevo;
                    }
                    else if (radioButton2.Checked) // Sheol (Inferno)
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.Sheol_Pintura;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.Sheol_representacao;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.Sheol_Canoeiro;
                    }
                    else if (radioButton3.Checked) // C�us e Astros
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.Cosmologia_Biblica___3_Sois;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.Cosmologia_Biblica___Astros;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.Cosmologia_Biblica___Eclipses;
                    }
                }
            }

            // ==========================================
            // LISTA 1: SOCIEDADES SECRETAS
            // ==========================================
            else if (listBox1.SelectedIndex == 1)
            {
                // ==========================================
                // SOCIEDADES SECRETAS > MA�ONARIA
                // ==========================================
                if (comboBox1.SelectedIndex == 0)
                {
                    if (radioButton1.Checked) // Loja Ma�onica
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.maconica_extrutura;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.graus;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.ritual_maconico;
                    }
                    else if (radioButton2.Checked) // Roupas
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.roupa_maconica;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.colar_macom;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.cartola_maconica;
                    }
                    else if (radioButton3.Checked) // Jachin e Boaz
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.jachin_e_boaz;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.jachin_boaz_significado;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.solomon_temple;
                    }
                }

                // ==========================================
                // SOCIEDADES SECRETAS > ILLUMINATIS
                // ==========================================
                else if (comboBox1.SelectedIndex == 1)
                {
                    if (radioButton1.Checked) // Simbolo
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.illuminati;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.nota_dolar;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.olho_que_tudo_ve;
                    }
                    else if (radioButton2.Checked) // Nota de d�lar
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.illuminati_nota_dolar;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.Terra_Plana___Mapa;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.Terra_Plana___Relevo;
                    }
                    else if (radioButton3.Checked) // Olho que tudo v�
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.Terra_Plana___Fotos;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.Terra_Plana___Mapa;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.Terra_Plana___Relevo;
                    }
                }
            }

            // ==========================================
            // LISTA 2: AURA & MAGIA
            // ==========================================
            else if (listBox1.SelectedIndex == 2)
            {
                // ==========================================
                // AURA & MAGIA > AURAS
                // ==========================================
                if (comboBox1.SelectedIndex == 0)
                {
                    if (radioButton1.Checked) // Representa��o
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.aura;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.desenho;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.aura_cores;
                    }
                    else if (radioButton2.Checked) // Cores
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.aura_vermelha;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.aura_azul;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.aura_verde;
                    }
                    else if (radioButton3.Checked) // Medindo Aura
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.kirlian;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.Terra_Plana___Mapa;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.Terra_Plana___Relevo;
                    }
                }

                // ==========================================
                // AURA & MAGIA > ORACULOS
                // ==========================================
                else if (comboBox1.SelectedIndex == 1)
                {
                    if (radioButton1.Checked) // Tarot
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.arcanos_maiores;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.arcanos_menores;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.lendo_tarot;
                    }
                    else if (radioButton2.Checked) // Baralho Cigano
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.baralho_cigano;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.lendo_baralho_cigano;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.baralho_cigano_simbolos;
                    }
                    else if (radioButton3.Checked) // Bola de Cristal
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.bola_de_cristal;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.lendo_bola_de_cristal;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.bola_de_cristal_2;
                    }
                }

                // ==========================================
                // AURA & MAGIA > MAGIA CERIMONIAL
                // ==========================================
                else if (comboBox1.SelectedIndex == 2)
                {
                    if (radioButton1.Checked) // Ars Goetia
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.stolas;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.selos_goetia;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.ritual_goetia;
                    }
                    else if (radioButton2.Checked) // Encantamentos
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.feiticos;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.magia_negra;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.abacadabra;
                    }
                    else if (radioButton3.Checked) // Itens
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.varinha;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.circulo_magico;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.incenso;
                    }
                }

                // ==========================================
                // AURA & MAGIA > NECROMANCIA
                // ==========================================
                else if (comboBox1.SelectedIndex == 3)
                {
                    if (radioButton1.Checked) // Idade Media
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.necromancia;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.circulo_necromante;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.ritual;
                    }
                    else if (radioButton2.Checked) // Rituais
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.circulo_necromante;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.ofertas_necromancia;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.cerimonia_necromante;
                    }
                    else if (radioButton3.Checked) // Exemplos
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.casos_necromante;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.necromancia_saul;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.odisseu_necromante;
                    }
                }
            }

            // ==========================================
            // LISTA 3: OBJETOS LENDARIOS
            // ==========================================
            else if (listBox1.SelectedIndex == 3)
            {
                // ==========================================
                // OBJETOS LENDARIOS > LAN�A DO DESTINO
                // ==========================================
                if (comboBox1.SelectedIndex == 0)
                {
                    if (radioButton1.Checked) // Representa��es
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.lanca_destino;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.lanca_pintura;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.lança_do_destino;
                    }
                    else if (radioButton2.Checked) // Lendas
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.lanca_historia;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.lenda_lanca_do_destino_god_of_war;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.lanca_mitologia;
                    }
                    else if (radioButton3.Checked) // Fontes
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.lanca_livros;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.lanca_documento;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.lanca_indiana_jones;
                    }
                }

                // ==========================================
                // OBJETOS LENDARIOS > SANTO GRAAL
                // ==========================================
                else if (comboBox1.SelectedIndex == 1)
                {
                    if (radioButton1.Checked) // Representa��es
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.santo_graal;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.santo_graal_pintura;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.santo_graal_replicas;
                    }
                    else if (radioButton2.Checked) // Lendas
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.santo_graal_rei_arthur;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.santo_graal_busca;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.salto_graal_mitologia2;
                    }
                    else if (radioButton3.Checked) // Fontes
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.santo_graal_livros;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.santo_graal_documentos;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.santo_graal_filme_ultima_cruzada;
                    }
                }

                // ==========================================
                // OBJETOS LENDARIOS > ARCA DA ALIAN�A
                // ==========================================
                else if (comboBox1.SelectedIndex == 2)
                {
                    if (radioButton1.Checked) // Representa��es
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.arca_da_alianca_pintura;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.arca_da_alianca_foto;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.arca_da_alianca_replicas1;
                    }
                    else if (radioButton2.Checked) // Lendas
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.arca_da_alianca_historia1;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.arca_da_alianca_poderes1;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.arca_da_alianca_mitologia1;
                    }
                    else if (radioButton3.Checked) // Fontes
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.arca_da_alianca_livro;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.arca_da_alianca_documentos;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.arca_da_alianca_filme;
                    }
                }
            }

            // ==========================================
            // LISTA 4: FALSOS DEUSES
            // ==========================================
            else if (listBox1.SelectedIndex == 4)
            {
                // ==========================================
                // FALSOS DEUSES > BAAL
                // ==========================================
                if (comboBox1.SelectedIndex == 0)
                {
                    if (radioButton1.Checked) // Origem
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.baal_cananeu;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.baal_mitologia;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.baal_historia;
                    }
                    else if (radioButton2.Checked) // Formas
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.baal_touro;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.baal_representacoes;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.baal_estatua;
                    }
                    else if (radioButton3.Checked) // Culto
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.baal_touro;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.baal_sacrificios1;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.baal_templo;
                    }
                }

                // ==========================================
                // FALSOS DEUSES > BAPHOMET
                // ==========================================
                else if (comboBox1.SelectedIndex == 1)
                {
                    if (radioButton1.Checked) // Origem
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.baphomet_templarios;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.baphomet_historia;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.baphomet_acusacao;
                    }
                    else if (radioButton2.Checked) // Formas
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.baphomet_cabeca_de_bode;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.baphomet_representacao_estatua;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.baphomet_simbolo;
                    }
                    else if (radioButton3.Checked) // Culto
                    {
                        if (checkBox1.Checked)
                            pictureBox1.Image = Properties.Resources.baphomet_ritual;

                        if (checkBox2.Checked)
                            pictureBox2.Image = Properties.Resources.baphomet_satanismo;

                        if (checkBox3.Checked)
                            pictureBox3.Image = Properties.Resources.baphomet_templo;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}

