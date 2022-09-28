using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Blood_Bank_MS
{
    public partial class BloodStock : Form
    {
      

        public BloodStock()
        {
            InitializeComponent();
        
        }

        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\admin\Documents\BbmsDB.accdb");

        
        
        private void BloodStock_Load(object sender, EventArgs e)
        {

        }
    }
}
