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
            string Database = "";
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
            MySqlConnection con = new MySqlConnection(connectionbuilder);
            String sql

        }
    }
}
