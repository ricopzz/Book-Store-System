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
    public partial class Change_Password : Form
    {
        BookStoreDBEntities ent = new BookStoreDBEntities();
        string userid;
        List<string> list;
        public Change_Password(string userid, List<string> list)
        {
            InitializeComponent();
            this.userid = userid;
            this.list = list;
        }

        

        private void Change_Password_Load(object sender, EventArgs e)
        {

        }

        private string getOldPass(string userid)
        {
            var query = from c in ent.Customers
                        where c.Customer_ID.Equals(userid)
                        select c.Password;
            return query.ToList().First();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var query = (from c in ent.Customers
                        where c.Customer_ID.Equals(userid)
                        select c).First();

            if(txtNewPassword.TextLength < 6)
            {
                MessageBox.Show("Password must be more than 6 characters");
            }
            else if (txtOldPassword.Text == getOldPass(userid) && txtNewPassword.TextLength >= 6)
            {
                query.Password = txtNewPassword.Text;
                ent.SaveChanges();
                this.Dispose();
                Customer_MainMenu main = new Customer_MainMenu(userid, list);
                main.Show();
            }
            else
            {
                MessageBox.Show("Old password is incorrect!");
            }
        }
    }
}
