using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management.AllUserControl
{
    public partial class UpdateItem : UserControl
    {
        DBhelper hp = new DBhelper();
        string query;
        public UpdateItem()
        {
            InitializeComponent();
        }

       

        private void UpdateItem_Load(object sender, EventArgs e)
        {
            query = "select * from items";
            loadData(query);
        }
        
        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where Name like '" + txtItemName.Text + "%'";
            loadData(query);
        }
        int id;
        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id=int.Parse(guna2DataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            String Category =guna2DataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            String Name =guna2DataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            int Price =int.Parse(guna2DataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString());

            txtcategory.Text = Category;
            txtName.Text = Name;
            txtPrice.Text = Price.ToString();

            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            query = "Update items set Name='" + txtName.Text + "' ,Category='" + txtcategory.Text + "' ,Price="+txtPrice.Text+" where Iid="+id+" ";
            hp.setData(query);
            string q = "select * from items";
            
            txtName.Clear();
            txtcategory.Clear();
            txtPrice.Clear();
            loadData(q);
        }
        public void loadData(string query)
        {

            DataSet ds = hp.getData(query);
            guna2DataGridView2.DataSource = ds.Tables[0];

        }

        private void UpdateItem_MouseEnter(object sender, EventArgs e)
        {
            string q = "select * from items";
            loadData(q);
        }

        private void UpdateItem_Enter(object sender, EventArgs e)
        {
            string q = "select * from items";
            loadData(q);
        }

    }
}
