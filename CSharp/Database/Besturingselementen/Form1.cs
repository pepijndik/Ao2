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
namespace Besturingselementen
{
    public partial class Form1 : Form
    {
        int catid = 1;
        OleDbConnection connectie = new OleDbConnection();
        void get(int catid, OleDbConnection connectie)
        {
            //String get_query = "SELECT * FROM Categorie INNER JOIN Recept ON [Categorie.Categorie-id] = Recept.Categorieid WHERE [Categorie.Categorie-id] ='" + nummer + "';";
            string query = "SELECT * FROM Categorie";
            DataSet ds1 = new DataSet();
            OleDbDataAdapter da = new OleDbDataAdapter(query,connectie);
            da.Fill(ds1, "Categorie");
            int MaxRows = ds1.Tables["Categorie"].Rows.Count;
            if(catid < MaxRows -1)
            {
                DataRow dRow = ds1.Tables["Categorie"].Rows[catid];
                txt_cat_id.Text = dRow.ItemArray.GetValue(0).ToString();
                txt_cat_naam.Text = dRow.ItemArray.GetValue(1).ToString();
                string query2 = "SELECT * FROM Recept WHERE Categorieid='"+catid+"'";
                DataSet ds2 = new DataSet();
                OleDbDataAdapter da2= new OleDbDataAdapter(query2, connectie);
                da2.Fill(ds2, "Naamrecept");
                dgridv.DataSource = ds2.Tables["Naamrecept"];
            }
           
         
        
        }
        public Form1()
        {
            InitializeComponent();
            connectie.ConnectionString = "provider = Microsoft.ACE.OLEDB.12.0;" + "Data Source = ..\\..\\Recepten.accdb;" +
                "Persist Security Info = False;";
            connectie.Open();
            get(catid, connectie);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            catid++;
             get(catid, connectie);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            catid--;
            get(catid, connectie);
        }

     
    }
}
