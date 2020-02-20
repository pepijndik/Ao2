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

namespace Uitleensysteem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Server = "localhost";
            string Database = "videotheek";
            String UID = "root";
            String pass = "";

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = Server;
            builder.Database = Database;
            builder.UserID = UID;
            builder.Password = pass;

            String connectionbuilder = builder.ToString();
            builder = null;
            MySqlDataReader mread = null;
            MySqlDataReader mread2 = null;
            MySqlConnection con = new MySqlConnection(connectionbuilder);

            MySqlConnection con2 = new MySqlConnection(connectionbuilder);
            String sql = "SELECT * FROM `klanten`";
            String sql2 = "SELECT * FROM `dvd`";
            MySqlCommand cmd = new MySqlCommand(sql,con);
            MySqlCommand command = new MySqlCommand(sql2, con2);
            con.Open();
            con2.Open();
            mread = cmd.ExecuteReader();
            mread2 = command.ExecuteReader();
            dgrid.DataSource = mread;
            dgrid2.DataSource = mread2;

            con.Close();



        }

        private void dgrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
