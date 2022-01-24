using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CafeEntities md = new CafeEntities();
        private void gunaTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnguest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard ds = new Dashboard("Guest");
            this.Hide();
            ds.Show();
            
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (md.authorizeds.Where(r => r.Name == txtuname.Text && r.Pass == txtpass.Text).Count() > 0)
            {
                Dashboard ds = new Dashboard(txtuname.Text);
                this.Hide();
                ds.Show();
            }
            else
            {
                authcheck.Text = "Wrong Credentials";
                
            }
        }
    }
}
