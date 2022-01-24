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
    public partial class AddItems : UserControl
    {
        DBhelper hp = new DBhelper();
        string query;
        public AddItems()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            query = "insert into Items(Name,Category,Price) values('" + txtitemname.Text + "','" + txtcategory.Text + "','" + txtprice.Text + "')";
            hp.setData(query);
            clearAll();
        }
        public void clearAll()
        {
            txtitemname.Clear();
            txtprice.Clear();
        }

        private void AddItems_Leave(object sender, EventArgs e)
        {
            
            txtcategory.SelectedIndex = -1;
            txtitemname.Clear();
            txtprice.Clear();
        }

        
    }
}
