using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace _1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source = ..\\..\\Recepten.accdb;" +
            "Persist Security Info = False;";
            con.Open();

            String query = "SELECT * FROM recept";

            OleDbCommand comm = new OleDbCommand(query, con);

            OleDbDataReader dbread = null;
            dbread = comm.ExecuteReader();

            var count = 0;
            while (dbread.Read())
            {
                count++;
                listBox1.Items.Add(dbread["Naam recept"].ToString());
            }
            txtaantal.Text = "Totaal aantal recepten: "+ count.ToString();

            dbread.Close();
            con.Close();
        }
    }
}
