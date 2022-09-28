using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Blood_Bank_MS
{
    public partial class login : Form
     {
        OleDbConnection Con = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

    public login()
        {
            InitializeComponent();
        }

      
        public static string loggedInUser;

        private void USERNAME_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {
            
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\admin\Documents\BbmsDB.accdb");
            //Con.Open();

            //OleDbDataAdapter da = new OleDbDataAdapter("Select Count(*)from LoginTb where Username=' " + txtUsername.Text + "'And Password='" + txtPassword.Text + "' ", Con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                MessageBox.Show("Welcome to Dashboard", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Main frm=new Main();
                frm.ShowDialog();
                Con.Close();
            }
            else
            {
                MessageBox.Show("Login Failed. Try Again.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
