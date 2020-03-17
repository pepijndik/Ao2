using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dierentuin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void excute_Click(object sender, EventArgs e)
        {
            dierentuin d = new dierentuin();
            lstbox.Items.Add(d.add(txtNaam.Text, txtGeluid.Text));
            

        }
    }
}
