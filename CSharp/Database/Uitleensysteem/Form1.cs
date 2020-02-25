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
     
            MySqlConnection con = new MySqlConnection(connectionbuilder);

            MySqlConnection con2 = new MySqlConnection(connectionbuilder);

            MySqlConnection con3 = new MySqlConnection(connectionbuilder);

            con2.Open();
            con3.Open();
            con.Open();
          
            MySqlDataReader dbread = null;
            MySqlDataReader dbread2 = null;
            MySqlDataReader dbread3 = null;

            //SQL querys
            String sql = "SELECT * FROM `klanten`";
            String sql2 = "SELECT * FROM `dvd`";
            String query_count = "SELECT COUNT(`Id-Dvd`) AS dvds FROM dvd";
            String query_count2 = "SELECT COUNT(`Id-Klant`) as klant FROM klanten";
            String query_count3 = "SELECT COUNT(`Id-Uitleengegevens`) as uitleen FROM uitleengegevens";
            //Uitgevoerde query's

            MySqlCommand command1 = new MySqlCommand(query_count, con);
            MySqlCommand command2 = new MySqlCommand(query_count2, con2);
            MySqlCommand command3 = new MySqlCommand(query_count3, con3);
            //Datagrids 
            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
            MySqlDataAdapter da2 = new MySqlDataAdapter(sql2, con);
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();
            da.Fill(ds1, "naam");
            da2.Fill(ds2, "naam");
            dgrid.DataSource = ds1.Tables["naam"];
            dgrid2.DataSource = ds2.Tables["naam"];
            dbread = command1.ExecuteReader();
            dbread2 = command2.ExecuteReader();
            dbread3 = command3.ExecuteReader();
            if(dbread.Read() && dbread2.Read() && dbread3.Read())
            {
                txt_klant.Text = dbread2["klant"].ToString();
                txt_arsort.Text = dbread3["uitleen"].ToString();
                txt_dvds.Text = dbread["dvds"].ToString();

            }


            con.Close();



        }

        private void dgrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
