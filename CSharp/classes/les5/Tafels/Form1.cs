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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private int _stoelen;
        private int _tafelnmr;

        public int Stoelen
        {
            get { return _stoelen; }
            set { _stoelen =  value; }
        }
        public int Tafelnmr
        {
            get { return _tafelnmr; }
            set { _tafelnmr = value; }
        }

        public void load()
        {
            lst_box.Items.Add(Stoelen.ToString() + Tafelnmr.ToString());
        }
    private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            

        }
    }
}
