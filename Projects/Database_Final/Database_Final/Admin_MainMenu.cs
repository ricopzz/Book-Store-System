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
    public partial class Admin_MainMenu : Form
    {
        string position;
        BookStoreEntities ent = new BookStoreEntities();


        public Admin_MainMenu(string position)
        {
            this.position = position;
            InitializeComponent();
        }

        public void refreshPublisherData()
        {
            var query = from c in ent.Publishers
                        select c;
            dataPublisher.DataSource = query.ToList();
        }

        public void refreshStaffData()
        {
            var query = from c in ent.Staffs
                        select c;
        }
        private void Admin_MainMenu_Load(object sender, EventArgs e)
        {
            if (position.Equals("Stock"))
            {
                tabAccount.Dispose();
            }
            else if (position.Equals("Request"))
            {
                tabPublisher.Dispose();
            }
            refreshPublisherData();
        }
    }
}
