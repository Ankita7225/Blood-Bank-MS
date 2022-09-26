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
    OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\admin\Documents\BbmsDB.accdb");    
    public partial class view_doner : Form
    {
        public view_doner()
        {
            InitializeComponent();
            populate();
        }

        private void populate()
        {
            Con.Open();
            string Query = "select  * from Donor";
            oleDbDataAdapter da = new oleDbDataAdapter(Query, Con);
            oleDbCommandBuilder builder = new oleDbCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DonorDGV.DataSource = ds.Tables[0];

            Con.close();
        }
        private void view_doner_Load(object sender, EventArgs e)
        {

        }
    }
}
