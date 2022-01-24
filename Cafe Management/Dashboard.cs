using Cafe_Management.AllUserControl;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(string user)
        {
            InitializeComponent();
            if (user == "Guest")
            {
                btnai.Hide();
                btnui.Hide();
                btnri.Hide();
                btnAnalysis.Hide();
            }
           
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnui_Click(object sender, EventArgs e)
        {
            sidebar.Height = btnpo.Height;
            sidebar.Top = btnui.Top;
            sidebar.BackColor = Color.WhiteSmoke;
          
            sidebar.Visible = true;
            updateItem1.Visible = true;
            updateItem1.BringToFront();

        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fa = new Form1();
            this.Hide();
            fa.Show();
        }

        private void ucWelcome1_Load(object sender, EventArgs e)
        {
            guna2Transition1.ShowSync(ucWelcome1);
        }

        private void btnai_Click(object sender, EventArgs e)
        {
            addItems1.Visible = true;
            addItems1.BringToFront();
           

            sidebar.Height = btnpo.Height;
            sidebar.Top = btnai.Top;
            sidebar.BackColor=Color.WhiteSmoke;
            sidebar.Visible = true;



        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            addItems1.Visible = false;
            placeOrder1.Visible = false;
            updateItem1.Visible = false;
            removeItem1.Visible = false;
            analysis1.Visible = false;
            

        }

        private void btnpo_Click(object sender, EventArgs e)
        {
            sidebar.Height = btnpo.Height;
            sidebar.Top = btnpo.Top;
            sidebar.BackColor = Color.WhiteSmoke;
            sidebar.Visible = true;

            ucWelcome1.Visible = false;
            guna2Transition1.ShowSync(placeOrder1);
            placeOrder1.Visible = true;
            placeOrder1.BringToFront();
        }

        private void btnri_Click(object sender, EventArgs e)
        {
            
            sidebar.Height = btnpo.Height;
            sidebar.Top = btnri.Top;
            sidebar.BackColor = Color.WhiteSmoke;
            sidebar.Visible = true;
            removeItem1.Visible = true;
            removeItem1.BringToFront();
         
            



        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            sidebar.Height = btnAnalysis.Height;
            sidebar.Top = btnAnalysis.Top;
            sidebar.BackColor = Color.WhiteSmoke;
            sidebar.Visible = true;
            analysis1.Visible = true;
            analysis1.BringToFront();
         
        }
    }
}
