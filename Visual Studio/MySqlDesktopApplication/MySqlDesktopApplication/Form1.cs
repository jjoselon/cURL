using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;

namespace MySqlDesktopApplication
{
    public partial class Form1 : Form
    {
        static string ConnectionString = "server=127.0.0.1;uid=root;pwd='';database=testconnectornet";
        MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(ConnectionString);

        public Form1()
        {
            InitializeComponent();
            OpenConnection();
        }

        MySql.Data.MySqlClient.MySqlConnection OpenConnection()
        {
            try
            {
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        {
                            MessageBox.Show("Cannot connect to server.  Contact administrator");
                        }
                        break;
                    case 1045:
                        {
                            MessageBox.Show("Invalid username/password, please try again");
                        }
                        break;
                    default:
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        break;
                }
            }
            return conn;
        }
        void CloseConnection()
        {
            conn.Close();
        }

        /**
         * El objeto MySql.Data.MySqlClient.MySqlDataReader es usado para recibir datos de la base de datos 
         */
        private void sqlSelect_Click(object sender, EventArgs e)
        {
            
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
            cmd.CommandText = "SELECT * FROM usuarios";
            cmd.Connection = conn;
            //cmd.CommandType = CommandType.TableDirect;
            MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                MessageBox.Show(reader.GetString(0));
            }
            // Es necesario cerrar el reader ya que solo puede haber asociado un reader a una connexión
            reader.Close();
        }

        private void sqlCreate_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand();
            cmd.CommandText = "INSERT INTO usuarios(nickname)";
            cmd.Connection = conn;
            //cmd.CommandType = CommandType.TableDirect;
            MySql.Data.MySqlClient.MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                MessageBox.Show(reader.GetString(0));
            }
        }
    }
}
