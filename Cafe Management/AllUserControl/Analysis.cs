using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cafe_Management.AllUserControl
{
    public partial class Analysis : UserControl
    {
        DBhelper hp = new DBhelper();
        string query;

        public Analysis()
        {
            InitializeComponent();
        }

        private void Analysis_Load(object sender, EventArgs e)
        {
            fillchart();
        }

        public void fillchart()
        {
            query = "select SUM(SaleAmount) as sales,SaleDate as Date  from Sales group by SaleDate";
            DataSet ds= hp.getData(query);

            chart1.DataSource = ds;

            chart1.Series["Sales"].XValueMember = "Date";

            chart1.Series["Sales"].YValueMembers = "sales";

            

        }

        private void Analysis_Enter(object sender, EventArgs e)
        {
            
            fillchart();
        }

        private void Analysis_MouseEnter(object sender, EventArgs e)
        {
           
            fillchart();
        }
    }
}
