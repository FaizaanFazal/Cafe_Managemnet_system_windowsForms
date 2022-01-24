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
    public partial class RemoveItem : UserControl
    {
        DBhelper hp= new DBhelper();
        string query;
        public RemoveItem()
        {
            InitializeComponent();
        }

        private void RemoveItem_Load(object sender, EventArgs e)
        {
            query = "select * from items";
            loaddata(query);
        }
        public void loaddata(string q)
        {        
            DataSet ds= hp.getData(q);
            guna2DataGridView3.DataSource= ds.Tables[0];
        }

        private void txtItemName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where Name like '" + txtItemName.Text + "%'";
            loaddata(query);
        }

        private void guna2DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(MessageBox.Show("Delete item","Important Message",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK){

                int id = int.Parse(guna2DataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from items where Iid=" + id;
                hp.setData(query);
                string q = "select * from items";
                loaddata(q);
            }
        }

        private void RemoveItem_Enter(object sender, EventArgs e)
        {
            string q = "select * from items";
            loaddata(q);
        }
    }
}
