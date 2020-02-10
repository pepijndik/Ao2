using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Db_1
{
    using System.Data.OleDb;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString = "provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source = C:\\Users\\pepij\\source\\repos\\Db_1\\Bruinsma.accdb;" +
            "Persist Security Info = False;";
            con.Open();

            String query = "SELECT * FROM klanten";

            OleDbCommand comm = new OleDbCommand(query, con);

            OleDbDataReader dbread = null;
            dbread = comm.ExecuteReader();

            while (dbread.Read())
            {
                listBox1.Items.Add(dbread["Voorletters"].ToString() + " " + dbread["tussenvoegsel"].ToString() + " " + dbread["achternaam"].ToString());
            }

            dbread.Close();
            con.Close();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
 