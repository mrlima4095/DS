using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public MySqlConnection conn;
        public MySqlCommand cmd;
        public MySqlDataReader reader;
        public MySqlDataAdapter adapter;
        public string strSQL = null;

        public Form1()
        {
            InitializeComponent();

            conn = new MySqlConnection("Server=localhost;Database=cliente;Uid=root;Pwd=@mar147");
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            strSQL = "INSERT INTO cad_cliente (nome, numero) VALUES (@nome, @numero)";
            cmd = new MySqlCommand(strSQL, conn);
            cmd.Parameters.AddWithValue("@nome", nome.Text);
            cmd.Parameters.AddWithValue("@numero", numero.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        private void edtBtn_Click(object sender, EventArgs e)
        {
            strSQL = "";
        }

        private void excBtn_Click(object sender, EventArgs e)
        {
            strSQL = "";
        }

        private void cnsBtn_Click(object sender, EventArgs e)
        {
            strSQL = "";

        }

        private void exiBtn_Click(object sender, EventArgs e)
        { 
            strSQL = "";
        }
    }
}
