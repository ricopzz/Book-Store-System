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
    public partial class Login_Form : Form
    {
        int counter = 0;

        public Login_Form()
        {
            InitializeComponent();
        }
        BookStoreDBEntities ent = new BookStoreDBEntities();

        public string getAccountStatus()
        {
            var query = from c in ent.Customers
                        where c.Username.Equals(txtUsername.Text)
                        && c.Password.Equals(txtPassword.Text)
                        select c.Status;

            return query.ToList().First();
        }

        public string returnPosition()
        {
            
            var query = from c in ent.Staffs
                        where c.Username.Equals(txtUsername.Text)
                        && c.Password.Equals(txtPassword.Text)
                        select c.Position;

            return query.ToList().First();
        }
        
        private string getuserID()
        {
            var query = from c in ent.Customers
                        where c.Username.Equals(txtUsername.Text)
                        select c.Customer_ID;

            return query.ToList().First();
        }
        
        private void Login_Form_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "http://www.kpopfans.net/wp-content/uploads/2016/02/160210-naeun.jpg";
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookStoreDBEntities ent = new BookStoreDBEntities();
            var query = from c in ent.Customers
                        where c.Username.Equals(txtUsername.Text)
                        && c.Password.Equals(txtPassword.Text)
                        select c;
            try
            {
                if (query.ToList().Count == 0)
                {
                    MessageBox.Show("Username or password is incorrect!");
                }
                else
                {
                    if (getAccountStatus() == "Verified")
                    {
                        MessageBox.Show("Login Successful");
                        this.Hide();
                        Customer_MainMenu custMain = new Customer_MainMenu(getuserID());
                        custMain.Show();
                    }
                    else
                    {
                        MessageBox.Show("Account has not been verified");
                    }
                }
            }
            catch
            {

            }
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            counter += 1;
            if(counter%2 == 0) // make the login button for normal user visible
            {
                panel1.Visible = true;
                panel2.Visible = true;
                btnLoginAsStaff.Text = "Login As Staff";
                lblTitle.Text = "Customer Login";
            }
            else // pop the login button for staff user
            {
                panel1.Visible = false;
                panel2.Visible = true;
                btnLoginAsStaff.Text = "Login As Customer";
                lblTitle.Text = "Staff Login";
            }
        }

        private void btnSignInStaff_Click(object sender, EventArgs e)
        {
            BookStoreDBEntities ent = new BookStoreDBEntities();
            var query = from c in ent.Staffs
                        where c.Username.Equals(txtUsername.Text)
                        && c.Password.Equals(txtPassword.Text)
                        select c;
            if (query.ToList().Count == 0)
            {
                MessageBox.Show("Username or password is incorrect!");
            }
            else
            {
                MessageBox.Show("Login Successful");
                this.Hide();
                Admin_MainMenu admMenu = new Admin_MainMenu(returnPosition(),txtUsername.Text);
                admMenu.Show();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Customer_Register register = new Customer_Register();
            register.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerifyCode verify = new VerifyCode();
            verify.Show();
        }
    }
}
