﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Blood_Bank_MS
{
    public partial class Patient_details : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public Patient_details()
        {
            InitializeComponent();
        }

        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\admin\Documents\BbmsDB.accdb");


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\admin\Documents\BbmsDB.accdb");
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Patient set Addr='" + txtAddress.Text + "'where Name = '" + txtName.Text + "'where Phone No ='" + txtPhoneNo.Text + "'where Date of Receiving blood'" + txtDateOfReceivingBlood.Text + "'where Age'" + txtAge.Text + "'where Bag No = '" + txtBagNo.Text + "'where Blood Group='" + cmbBloodGroup.SelectedIndex.ToString() + "'where Gender='" + cmbGender.SelectedIndex.ToString() + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("data Updated");
                da = new OleDbDataAdapter("select * from Patient", con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                con.Close();
            }
            catch
            {
                MessageBox.Show("not updated");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\admin\Documents\BbmsDB.accdb");

                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Delete Patient set Addr='" + txtAddress.Text + "'where Name = '" + txtName.Text + "'where Phone No ='" + txtPhoneNo.Text + "'where Date of Receiving blood'" + txtDateOfReceivingBlood.Text + "'where Age'" + txtAge.Text + "'where Bag No = '" + txtBagNo.Text + "'where Blood Group='" + cmbBloodGroup.SelectedIndex.ToString() + "'where Gender='" + cmbGender.SelectedIndex.ToString() + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("deleted");
                da = new OleDbDataAdapter("select * from Donor", con);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            catch
            {
                MessageBox.Show("not deleted");
            }
        }
    }
}
