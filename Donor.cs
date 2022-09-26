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
    public partial class Donor : Form
    {
        OleDbConnection Con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        public Donor()
        {
            InitializeComponent();
        }

        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\admin\Documents\BbmsDB.accdb");

        private void Reset()
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtAge.Text = "";
            txtPhoneNo.Text = "";
            txtTotalDonation.Text = "";
            cmbBloodGroup.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAddress.Text=="" ||txtPhoneNo.Text == "" || txtAge.Text == "" || txtTotalDonation.Text==""||cmbGender.SelectedIndex == -1 || cmbBloodGroup.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = " insert into Donor values(' " + txtName.Text + " ',' " + txtAddress.Text + " ','" + cmbBloodGroup.SelectedIndex.ToString() + "','" + txtPhoneNo.Text + "','" + txtAge.Text + "','" + cmbGender.SelectedIndex.ToString()+ ",' " + txtTotalDonation.Text + " ')";
                    Con.Open();
                    cmd = new OleDbConnection(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Saved");
                    Con.Close();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }

        }
    }
}
