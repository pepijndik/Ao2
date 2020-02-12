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
            OleDbConnection con1 = new OleDbConnection();
            con1.ConnectionString = "provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source = ..\\..\\Bruinsma.accdb;" +
            "Persist Security Info = False;";
            con1.Open();

            String query = "SELECT * FROM Klanten";

            OleDbCommand comm = new OleDbCommand(query, con1);

            OleDbDataReader dbread = null;

            dbread = comm.ExecuteReader();
            while (dbread.Read())
            {
                lst_load.Items.Add(dbread["Voorletters"].ToString()
                + " " +
                dbread["Tussenvoegsel"].ToString() + " " +
                dbread["Achternaam"].ToString());
            }
            dbread.Close();
            con1.Close();
          
            
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        //string selected = listBox1.GetItemText(listBox1.SelectedItem);

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con1 = new OleDbConnection();
            con1.ConnectionString = "provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source = ..\\..\\Bruinsma.accdb;" +
            "Persist Security Info = False;";
            con1.Open();
            String voornaam = txtvoornaam.Text;
            String achternaam = txtAchternaam.Text;
            String tussenvoeg = txtTussenvoegsel.Text;
            String Straat = txtStraat.Text;
            String Huisnummer = txtHuisnummer.Text;
            String Toevoeging = txtTvHuis.Text;
            String Postcode = txtPostcode.Text;
            String woonplaats = txtWoonplaats.Text;
            String telefoon = txtTelefoon.Text;
            String Query1 = "INSERT INTO Klanten (Voorletters, Tussenvoegsel, Achternaam, Straat, Huisnummer, [Toevoeging huisnummer], Postcode, Woonplaats, Telefoon) VALUES('" + voornaam + "','" + tussenvoeg + "','" + achternaam + "','" + Straat + "','" + Huisnummer + "','" +Toevoeging+ "','" + Postcode + "','" + woonplaats + "','" + telefoon + "')";

            OleDbCommand comm = new OleDbCommand(Query1, con1);
            comm.ExecuteNonQuery();
            comm.Dispose();
            con1.Close();
            

        }

        private void Verander_Click(object sender, EventArgs e)
        {
            String voornaam = txtvoornaam.Text;
            String achternaam = txtAchternaam.Text;
            String tussenvoeg = txtTussenvoegsel.Text;
            String Straat = txtStraat.Text;
            String Huisnummer = txtHuisnummer.Text;
            String Toevoeging = txtTvHuis.Text;
            String Postcode = txtPostcode.Text;
            String woonplaats = txtWoonplaats.Text;
            String telefoon = txtTelefoon.Text;
            OleDbConnection con1 = new OleDbConnection();
            con1.ConnectionString = "provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source = ..\\..\\Bruinsma.accdb;" +
            "Persist Security Info = False;";
            con1.Open();

            String query = "UPDATE Klanten SET Voorletters = '"+voornaam+"', Tussenvoegsel = '"+tussenvoeg+ "',Achternaam='"+achternaam+ "' ,Straat='" + Straat + "',Huisnummer='" + Huisnummer + "',[Toevoeging huisnummer]='" + Toevoeging + "',Postcode='" + Postcode  + "',Woonplaats='" + woonplaats + "',Telefoon='" + telefoon +" WHERE condition; ";
            OleDbCommand comm = new OleDbCommand(query, con1);
            comm.ExecuteNonQuery();
            comm.Dispose();
            con1.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

            string selected_item = lst_load.GetItemText(lst_load.SelectedItem);
            string voorletters = selected_item.Substring(0, 2);
            OleDbConnection con2 = new OleDbConnection();
            con2.ConnectionString = "provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source = ..\\..\\Bruinsma.accdb;" +
          "Persist Security Info = False;";
            con2.Open();
            string query2 = "Select * FROM Klanten WHERE Voorletters ='" + voorletters + "'";
            OleDbCommand comm2 = new OleDbCommand(query2, con2);
            OleDbDataReader dataread = null;
            dataread = comm2.ExecuteReader();
            while (dataread.Read())
            {
                String voornaam = dataread["Voorletters"].ToString();
                String achternaam = dataread["Achternaam"].ToString();
                String tussenvoegsel = dataread["Tussenvoegsel"].ToString();
                String straat = dataread["Straat"].ToString();

                String huisnummer = dataread["Huisnummer"].ToString();
                String tvhuis = dataread["Toevoeging huisnummer"].ToString();
                String postcode = dataread["Postcode"].ToString();
                String woonplaats = dataread["Woonplaats"].ToString();
                String tel = dataread["Telefoon"].ToString();
                txtvoornaam.Text = voornaam;
                txtAchternaam.Text = achternaam;
                txtTussenvoegsel.Text = tussenvoegsel;
                txtStraat.Text = straat;
                txtHuisnummer.Text = huisnummer;
                txtTvHuis.Text = tvhuis;
                txtPostcode.Text = postcode;
                txtWoonplaats.Text = woonplaats;
                txtTelefoon.Text = tel;
            }
            comm2.Dispose();
            con2.Close();
        }
    }
}
