using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturante
{
    public partial class ConclusaoForm : Form
    {
        public ConclusaoForm(string recibo)
        {
            InitializeComponent();
            textBox1.Text = recibo;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvar = new SaveFileDialog();
            salvar.Title = "Salvar nota fiscal";
            salvar.Filter = "Arquivo de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            salvar.FileName = "nota.txt";
            salvar.DefaultExt = "txt";
            salvar.InitialDirectory = Application.StartupPath;

            if (salvar.ShowDialog(this) == DialogResult.OK)
            {
                File.WriteAllText(salvar.FileName, textBox1.Text, Encoding.UTF8);

                MessageBox.Show("Nota salva em:" + Environment.NewLine + salvar.FileName, "Nota fiscal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
