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
namespace _2._1
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
            con.ConnectionString = "provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source = ..\\..\\Bruinsma.accdb;" +
            "Persist Security Info = False;";
            con.Open();
            String voornaam = txtvoornaam.Text;
            String achternaam = txtAchternaam.Text;
            String tussenvoeg = txtTussenvoegsel.Text;
            String Straat = txtStraat.Text;
            String Huisnummer = txtHuisnummer.Text;
            String Toevoeging = txtTvHuis.Text;
            String Postcode = txtPostcode.Text;
            String woonplaats = txtWoonplaats.Text;
            String telefoon = txtTelefoon.Text;
            String sql = "INSERT INTO klanten (Voorletters,Tussenvoegsel,Achternaam,straat,Huisnummer,Toevoeging huisnummer,Postcode,Woonplaats,telfoon) VALUES('"+voornaam+"','" + tussenvoeg + "','" + achternaam + "','" + Straat + "','" + Huisnummer + "','" + Postcode + "','"+ woonplaats + "','"+telefoon+ "')";

            OleDbCommand comm = new OleDbCommand(sql, con);
            this.Close();
        }
       

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
