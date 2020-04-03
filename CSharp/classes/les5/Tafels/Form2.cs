using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tafels
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_excute_Click(object sender, EventArgs e)
        {
           if( MessageBox.Show("Wilt u dit echt?","Object toevoegen",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                //Toevoegen aan list box
                Form1 frm1 = new Form1();
                frm1.Stoelen = int.Parse(txt_Stoelen.Text);
                frm1.Tafelnmr = int.Parse(txt_tafelNrm.Text);
                frm1.load();
                this.Close();
            }
            else
            {
                //Niet toevoegen
            }
        }
    }
}
