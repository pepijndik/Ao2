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
namespace _1._3
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
            con.ConnectionString = "provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source = ..\\..\\Vlinders.accdb;" +
            "Persist Security Info = False;";
            con.Open();

            String query = "SELECT Familienamen.Familienaam AS Famnaam, Count(*) AS Aantalvlinders FROM Familienamen INNER JOIN Vlinders ON Familienamen.[Familie-Id] = Vlinders.Familienaam GROUP BY Familienamen.Familienaam;";

            OleDbCommand comm = new OleDbCommand(query, con);

            OleDbDataReader dbread = null;

            listBox1.Items.Add("Famnaam"
                + " " +
            "Aantalvlinders");

            dbread = comm.ExecuteReader();
            while (dbread.Read())
            {
                listBox1.Items.Add(dbread["Famnaam"].ToString()
                + " " +
                dbread["Aantalvlinders"].ToString());
            }

            query = "SELECT COUNT(*) FROM Vlinders";
            OleDbCommand com2 = new OleDbCommand(query, con);

            txtaantal.Text = com2.ExecuteScalar().ToString();

            dbread.Close();
            con.Close();
        }
    }
}
