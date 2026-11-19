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
        public string rconn = "Server=localhost;Database=db;Uid=root;Pwd=";

        public Form1()
        {
            InitializeComponent();
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            try
            {
                strSQL = "INSERT INTO cad_cliente (nome, numero) VALUES (@nome, @numero)";

                conn = new MySqlConnection(rconn);
                cmd = new MySqlCommand(strSQL, conn);
                cmd.Parameters.AddWithValue("@nome", nome.Text);
                cmd.Parameters.AddWithValue("@numero", numero.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                conn = null;
                cmd = null;
            }
        }

        private void edtBtn_Click(object sender, EventArgs e)
        {
            try
            {
                strSQL = "UPDATE cad_cliente SET nome = @nome, numero = @numero WHERE id = @id";

                conn = new MySqlConnection(rconn);
                cmd = new MySqlCommand(strSQL, conn);
                cmd.Parameters.AddWithValue("@id", id.Text);
                cmd.Parameters.AddWithValue("@nome", nome.Text);
                cmd.Parameters.AddWithValue("@numero", numero.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                conn = null;
                cmd = null;
            }
        }

        private void excBtn_Click(object sender, EventArgs e)
        {
            try
            {
                strSQL = "DELETE FROM cad_cliente WHERE id = @id";

                conn = new MySqlConnection(rconn);
                cmd = new MySqlCommand(strSQL, conn);
                cmd.Parameters.AddWithValue("@id", id.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                conn = null;
                cmd = null;
            }
        }

        private void cnsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                strSQL = "SELECT * FROM cad_cliente WHERE id = @id";

                conn = new MySqlConnection(rconn);
                cmd = new MySqlCommand(strSQL, conn);
                cmd.Parameters.AddWithValue("@id", id.Text);

                conn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    nome.Text = Convert.ToString(reader["nome"]);
                    numero.Text = Convert.ToString(reader["numero"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                conn = null;
                cmd = null;
            }
        }

        private void exiBtn_Click(object sender, EventArgs e)
        {
            try
            {
                strSQL = "SELECT * FROM cad_cliente";

                conn = new MySqlConnection(rconn);
                adapter = new MySqlDataAdapter(strSQL, conn);

                DataTable dt = new DataTable();

                adapter.Fill(dt);
                tabela.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                conn = null;
                cmd = null;
            }
        }
    }
}
