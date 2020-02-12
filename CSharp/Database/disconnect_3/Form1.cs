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
namespace disconnect_3
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

            string sql = "SELECT vlinders.naam,Familienamen.familienaam FROM vlinders INNER JOIN Familienamen ON vlinders.familienaam = [Familienamen.Familie-Id]; ";
            OleDbDataAdapter da = new OleDbDataAdapter(sql,con);
            DataSet ds1 = new DataSet();
            
            da.Fill(ds1, "naam");
            dgv.DataSource = ds1.Tables["naam"];

        }
    }
}
