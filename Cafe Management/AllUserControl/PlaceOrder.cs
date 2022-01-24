using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DGVPrinterHelper;
namespace Cafe_Management.AllUserControl
{
    public partial class PlaceOrder : UserControl
    {
        DBhelper hp = new DBhelper();
        string query;
        public PlaceOrder()
        {
            InitializeComponent();
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            String category = comboCategory.Text;
             query = "select Name from items where Category='" + category + "'";
             showitem(query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
            String category = comboCategory.Text;
            query = "select Name from items where Category='" + category + "' and Name like '"+txtSearch+"%'";
            showitem(query);
        }

        private void showitem(string querry)
        {
            listView1.Items.Clear();
            DataSet ds = hp.getData(query);
            int i;
            for (i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listView1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtupdown.Value = 0;
           
            txttotal.Clear();
            if (listView1.SelectedItems.Count > 0)
            {
                String text = listView1.SelectedItems[0].Text;
                txtItemName.Text = text;
                query = "select Price from items where Name='" + text + "'";
                DataSet ds = hp.getData(query);
                txtprice.Text = ds.Tables[0].Rows[0][0].ToString();
                
            }
            else
            {
                return;
            }
            

        }

        private void txtupdown_ValueChanged(object sender, EventArgs e)
        {
            int quan = int.Parse(txtupdown.Value.ToString());
            int price = int.Parse(txtprice.Text.ToString());
            txttotal.Text = (quan * price).ToString();
        }
        protected int n, total = 0;
        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if (txttotal.Text != "0" && txttotal.Text != "") { 
            n = guna2DataGridView1.Rows.Add();
            guna2DataGridView1.Rows[n].Cells[0].Value = txtItemName.Text;
            guna2DataGridView1.Rows[n].Cells[1].Value = txtprice.Text;
            guna2DataGridView1.Rows[n].Cells[2].Value = txtupdown.Text;
            guna2DataGridView1.Rows[n].Cells[3].Value = txttotal.Text;

            total = total + int.Parse(txttotal.Text.ToString());
            lblPrice.Text = "Rs." + total.ToString();
            }
            else
            {
                MessageBox.Show("Minimum Quantity need to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        int amount;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch
            {

            }

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                guna2DataGridView1.Rows.RemoveAt(this.guna2DataGridView1.SelectedRows[0].Index);
            }
            catch
            {

            }
            total -= amount;
            lblPrice.Text = "Rs." + total;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            query = "insert into Sales(SaleAmount) values('" + total+ "')";
            hp.setData(query);


            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payable Amount :" + lblPrice.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(guna2DataGridView1);

            total = 0;
            guna2DataGridView1.Rows.Clear();
            lblPrice.Text = "Rs." + total;
        }
    }
}
