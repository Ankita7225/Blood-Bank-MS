using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Blood_Bank_MS
{
    public partial class Donor : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BbDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private bool isEdit=false;

        public Donor()
        {
            InitializeComponent();
            fillGrid();
            tabControl1.TabPages.Remove(tabPage2);

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

       
        void fillGrid()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Donor", con);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        
            

       

        private void btnedit_Click(object sender, EventArgs e)
        {
            isEdit = true;
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Add(tabPage2);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtid.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            txtAddress.Text = row.Cells[2].Value.ToString();
            txtAge.Text = row.Cells[3].Value.ToString();
            cmbBloodGroup.Text = row.Cells[4].Value.ToString();
            txtTotalDonation.Text = row.Cells[5].Value.ToString();
            cmbGender.Text = row.Cells[6].Value.ToString();
            txtPhoneNo.Text = row.Cells[7].Value.ToString();
            txtDate.Text = row.Cells[8].Value.ToString();

        }

        private void btncancle_Click(object sender, EventArgs e)
        {
            isEdit = false;
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Add(tabPage1);

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            isEdit = false;
            tabControl1.TabPages.Remove(tabPage1);
            tabControl1.TabPages.Add(tabPage2);

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            if (isEdit == true)
            {
                if (txtid.Text != "" && txtName.Text != "")
                {

                    SqlCommand cmd = new SqlCommand("update Donor set Name=@name,Address=@address,Age=@age,dateofdonation=@date,totalDonation=@totaldonation,gender=@gender,phoneno=@phoneno,Bloodgroup=@Bloodgroup where ID=@id", con);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();

                    }
                    cmd.Parameters.AddWithValue("@id", txtid.Text);
                    cmd.Parameters.AddWithValue("@name", txtName.Text);
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@age", txtAge.Text);
                    cmd.Parameters.AddWithValue("@date", txtDate.Text);
                    cmd.Parameters.AddWithValue("@totaldonation", txtTotalDonation.Text);
                    cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                    cmd.Parameters.AddWithValue("@phoneno", txtPhoneNo.Text);
                    cmd.Parameters.AddWithValue("@Bloodgroup", cmbBloodGroup.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated Successfully");
                    con.Close();
                    fillGrid();
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Add(tabPage1);
                    //SqlCommand cmd2 = new SqlCommand("Select bloodSt from BStock where BloodGroup='" + cmbBloodGroup.Text + "'", con);

                    //SqlDataReader reader = cmd2.ExecuteReader();
                    ////int Stock = (int)reader[0];
                    ////Stock += Convert.ToInt32(cmbBloodGroup.Text);

                    ////cmd2 = new SqlCommand($"Update BStock set BloodSt={Stock} where BloodGroup='" + cmbBloodGroup.Text + "'", con);
                    ////cmd2.ExecuteNonQuery();



                }
                else
                {
                    MessageBox.Show("Please Select Record to Update");
                }


            }
            else
            {

                if (txtName.Text == "" || txtAddress.Text == "" || txtPhoneNo.Text == "" || txtAge.Text == "" || txtTotalDonation.Text == "" || cmbGender.Text == "" || cmbBloodGroup.Text == "" || txtDate.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    try
                    {
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();

                        }

                        SqlCommand cmd = new SqlCommand("insert into Donor values(' " + txtName.Text + " ',' " + txtAddress.Text + " ','" + txtAge.Text + "','" + cmbBloodGroup.Text + "',' " + txtTotalDonation.Text + " ','" + cmbGender.Text + "','" + txtPhoneNo.Text + "','" + txtDate.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Saved");
                        con.Close();
                        Reset();
                        fillGrid();
                        tabControl1.TabPages.Remove(tabPage2);
                        tabControl1.TabPages.Add(tabPage1);
                        SqlCommand cmd2 = new SqlCommand("Select bloodSt from BStock where BloodGroup='" + cmbBloodGroup.Text + "'",con);

                        SqlDataReader reader = cmd2.ExecuteReader();
                        int Stock= (int)reader[0];
                        Stock+=Convert.ToInt32(cmbBloodGroup.Text);

                        cmd2 =  new SqlCommand($"Update BStock set BloodSt={Stock} where BloodGroup='"+cmbBloodGroup.Text+"'",con);
                        cmd2.ExecuteNonQuery();



                    }

                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);

                    }
                }


            }   
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            try
            {

                SqlCommand cmd = new SqlCommand("Delete from Donor where ID= '" + dataGridView1.SelectedRows[0].Cells[0].Value + "' ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("data deleted");
                con.Close();
                fillGrid();
                
            }
            catch
            {
                MessageBox.Show("not deleted");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblid_Click(object sender, EventArgs e)
        {

        }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void txtTotalDonation_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotalDonations_Click(object sender, EventArgs e)
        {

        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBloodGroup_Click(object sender, EventArgs e)
        {

        }

        private void cmbBloodGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblAge_Click(object sender, EventArgs e)
        {

        }

       

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void Donor_Load(object sender, EventArgs e)
        {

        }
    }
}
