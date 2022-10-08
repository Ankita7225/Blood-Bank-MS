using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;


namespace Blood_Bank_MS
{
    public partial class Patient : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BbDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        private bool isEdit = false;
        public Patient()
        {
            InitializeComponent();
            fillGrid();
            tabControl1.TabPages.Remove(tabPage2);
        }


        private void Reset()
        {
            txtname.Text = "";
            txtAddress.Text = "";
            txtAge.Text = "";
            cmbBloodGroup.SelectedIndex = -1;
            txtPhoneNo.Text = "";
            cmbGender.SelectedIndex = -1;
            txtbagno.Text = "";
            txtdateofReceivinigblood.Text = "";
        }
        void fillGrid()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Patient", con);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
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
            txtname.Text = row.Cells[1].Value.ToString();
            txtAddress.Text = row.Cells[2].Value.ToString();
            txtAge.Text = row.Cells[3].Value.ToString();
            cmbBloodGroup.Text = row.Cells[4].Value.ToString();
            txtPhoneNo.Text = row.Cells[5].Value.ToString();
            cmbGender.Text = row.Cells[6].Value.ToString();
            txtbagno.Text = row.Cells[7].Value.ToString();
            txtdateofReceivinigblood.Text = row.Cells[8].Value.ToString();

        }












        private void btnSubmit_Click(object sender, EventArgs e)
        {

            
            }

        }

        

       

      
        }
    
