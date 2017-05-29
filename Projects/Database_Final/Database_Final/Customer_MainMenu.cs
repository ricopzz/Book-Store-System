using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Final
{
    public partial class Customer_MainMenu : Form
    {
        BookStoreEntities ent = new BookStoreEntities();

        public Customer_MainMenu()
        {
            InitializeComponent();
        }

        private void Customer_MainMenu_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            refreshData();
            dataNewReleases.AutoResizeRows();
        }

        private void refreshData()
        {
            var query = from c in ent.Products
                        // where c.Date_Publish < now()
                        select new { BookTitle= c.Product_Title };
            dataNewReleases.DataSource = query.ToList();
        }

        private void dataNewReleases_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
