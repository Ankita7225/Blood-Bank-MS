using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Blood_Bank_MS
{
    public partial class BloodStock : Form
    {
      

        public BloodStock()
        {
            InitializeComponent();
            bloodStock();        
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BbDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void bloodStock()
        {
            con.Open();
            string query = "Select * from BStock";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BloodstockdataGridView.DataSource = ds.Tables[0];
            con.Close();
        
        }




        private void BloodStock_Load(object sender, EventArgs e)
        {

        }
    }
}
