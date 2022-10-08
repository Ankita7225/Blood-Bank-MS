using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Blood_Bank_MS
{
    public partial class New_login : Form
    {
        string passpattern = @"(?=^.{8,}$)((?=.\d)|(?=.\w+))(?![.\n])(?=.[A-Z)(?=.[a-z]).*$";
        public New_login()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" && txtPassword.Text == "" && txtconfirmpw.Text == "")
            {
                MessageBox.Show("Username and password field should not empty ", "registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text != txtconfirmpw.Text)
            {
                MessageBox.Show(" Sorry Try Again ", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtUsername.Text != "" && txtPassword.Text != "" && txtconfirmpw.Text != "")
            {
                string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "insert into  tb_login values(@username ,@password)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.ExecuteNonQuery();

                string query2 = "insert into tb_register values (@username,@password)";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                cmd2.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd2.Parameters.AddWithValue("@password", txtPassword.Text);
                int a = cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("User Registered Successfully", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new login().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("User Registered Failed ", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
