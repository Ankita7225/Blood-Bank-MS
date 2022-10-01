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
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\BbmsDB.accdb");
        OleDbCommand cmd = new OleDbCommand();

        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public Donor()
        {
            InitializeComponent();
            fillGrid();

        }



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


            if (txtName.Text == "" || txtAddress.Text == "" || txtPhoneNo.Text == "" || txtAge.Text == "" || txtTotalDonation.Text == "" || cmbGender.SelectedIndex == -1 || cmbBloodGroup.SelectedIndex == -1 || txtDate.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = " insert into Donor values(' " + txtName.Text + " ',' " + txtAddress.Text + " ','" + cmbBloodGroup.SelectedIndex.ToString() + "','" + txtPhoneNo.Text + "','" + txtAge.Text + "','" + cmbGender.SelectedIndex.ToString() + ",' " + txtTotalDonation.Text + " ','" + txtDate.Text + "')";
                    con.Open();
                    cmd = new OleDbCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Saved");
                    con.Close();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);

                }
            }

        }

        void fillGrid()
        {
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Donor", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

    }
}
