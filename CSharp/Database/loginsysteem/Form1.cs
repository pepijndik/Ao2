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
namespace loginsysteem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OleDbConnection con1 = new OleDbConnection();
            con1.ConnectionString = "provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source = ..\\..\\loginsysteem.accdb;" +
            "Persist Security Info = False;";
            con1.Open();
            OleDbDataReader dbread = null;
            String query = "select * from gebruikers where gebruikersnaam= @gebruikersnaam AND wachtwoord = @wachtwoord";

            OleDbCommand dbcom = new OleDbCommand(query, con1);
            OleDbParameter param1 = new OleDbParameter();
            param1.ParameterName = "@gebruikersnaam";
            param1.Value = txt_gbr.Text;

            OleDbParameter param2 = new OleDbParameter();
            param2.ParameterName = "@wachtwoord";
            param2.Value = txt_pass.Text;

            dbcom.Parameters.Add(param1);
            dbcom.Parameters.Add(param2);
            dbread = dbcom.ExecuteReader();

            if (dbread.HasRows)
            {
                MessageBox.Show("Ingelogd");
            }
            else
            {
                MessageBox.Show("Informatie is niet juist");
            }

        }

    }
}