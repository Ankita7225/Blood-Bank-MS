using Blood_Bank_MS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;

namespace Blood_Bank_MS
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void cmbquantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }


        private void CalculatePrice()
        {
            if ( cmbquantity.Text != "" && txtprice.Text != "")
            {
                decimal Totalamount = Convert.ToInt32(cmbquantity.Text) * Convert.ToInt32(txtprice.Text) ;
                txtamount.Text = Totalamount.ToString();

            }            
            else
            {
                txtamount.Text = "0";
            }
        }

                
        
        private void txtprice_TextChanged(object sender, EventArgs e)
        {
            CalculatePrice();
        }
        private void btnprint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void btnprintpreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Image image = Resources.bill;
            g.DrawImage(image, 30, 30, 750, 300);
            e.Graphics.DrawString("BLOOD BANK", new Font("Century Gothic", 20, FontStyle.Bold), Brushes.Black, new Point(350));
            e.Graphics.DrawString("Customer Name:" + txtName.Text, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(25, 350));
            e.Graphics.DrawString("Date:" + DateTime.Now, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(25, 325));
            e.Graphics.DrawString("Customer Phone Number:" + txtPhoneNo.Text, new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(25, 375));
            e.Graphics.DrawString("-----------------------------------------------------------------------------------", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(25, 400));
            e.Graphics.DrawString("Item Description", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(25, 420));
            e.Graphics.DrawString("Quantity", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(410, 420));
            e.Graphics.DrawString("Price", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(600, 420));
            e.Graphics.DrawString("-----------------------------------------------------------------------------------", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(25, 440));
            e.Graphics.DrawString(cmbBloodGroup.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(25, 480));
            e.Graphics.DrawString(cmbquantity.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(410, 480));
            e.Graphics.DrawString("RS." + txtprice.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(700, 500));
            e.Graphics.DrawString("-----------------------------------------------------------------------------------", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(25, 800));
            e.Graphics.DrawString("Total Amount ", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(25, 825));
            e.Graphics.DrawString("RS." + txtamount.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(700, 825));
            e.Graphics.DrawString("-----------------------------------------------------------------------------------", new Font("Arial", 18, FontStyle.Regular), Brushes.Black, new Point(25, 850));

        }

    }
}


