using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Blood_Bank_MS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashborad form = new Dashborad();
            panelBody.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelBody.Controls.Add(form);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelBody.Controls.Clear();
            Donor form = new Donor();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelBody.Controls.Add(form);
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             panelBody.Controls.Clear();
            Patient form = new Patient();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelBody.Controls.Add(form);
            form.Show();
        }

        private void HOSPITAL_Click(object sender, EventArgs e)
        {
            panelBody.Controls.Clear();
            Hospital form = new Hospital();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelBody.Controls.Add(form);
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelBody.Controls.Clear();
            BloodStock form = new BloodStock();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelBody.Controls.Add(form);
            form.Show();
        }

        private void Payment_Click(object sender, EventArgs e)
        {
            panelBody.Controls.Clear();
            Payment form = new Payment();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelBody.Controls.Add(form);
            form.Show();
        }

        private void history_Click(object sender, EventArgs e)
        {
            panelBody.Controls.Clear();
            History form = new History ();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelBody.Controls.Add(form);
            form.Show();
        }

        private void Event_Click(object sender, EventArgs e)
        {
            panelBody.Controls.Clear();
            Event form = new Event();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelBody.Controls.Add(form);
            form.Show();
        }
    }
}
