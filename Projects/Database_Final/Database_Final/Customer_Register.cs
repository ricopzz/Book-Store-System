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
    public partial class Customer_Register : Form
    {
        BookStoreDBEntities ent = new BookStoreDBEntities();
        Login_Form loginForm = new Login_Form();
        public Customer_Register()
        {
            InitializeComponent();
        }

        private string getLastID()
        {
            try
            {
                var query = from c in ent.Customers
                            orderby c.Customer_ID
                            select c.Customer_ID;
                string code = query.ToList().Last();
                return code;
            }
            catch
            {
                return "CST00000";
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtEmail.Text == "" || txtName.Text == "" || txtPassword.Text == "" || txtPhone.Text == "" || txtUsername.Text == "")
            {
                MessageBox.Show("Please fill in all fields!");
            }
            else if (rbFemale.Checked == false && rbMale.Checked == false)
            {
                MessageBox.Show("Please choose your gender!");
            }
            else if (boxFav.SelectedIndex == -1 || boxFav.SelectedItem == "")
            {
                MessageBox.Show("Please choose your job!");
            }
            else if (txtPassword.TextLength < 6)
            {
                MessageBox.Show("Password must be more than 6 characters!");
            }
            else
            {
                try
                {
                    String gender;
                    if (rbFemale.Checked) gender = "Female";
                    else gender = "Male";

                    int id = Int32.Parse(getLastID().Substring(3)) + 1;
                    String custid = "CST" + id.ToString().PadLeft(5, '0');

                    var data = new Customer
                    {
                        Customer_ID = custid,
                        Customer_Name = txtName.Text,
                        Customer_Address = txtAddress.Text,
                        Preffered_Genre = boxFav.Text,
                        Birth_Date = birthDatePicker.Value,
                        Phone_Number = txtPhone.Text,
                        Username = txtUsername.Text,
                        Password = txtPassword.Text,
                        Email = txtEmail.Text,
                        Gender = gender,
                        Status = "NOT VERIFIED",
                        Balance = 0
                    };
                    ent.Customers.Add(data);
                    VerifyCode verify = new VerifyCode();
                    ent.SaveChanges();
                    MessageBox.Show("Please verify your account to log-in");
                    this.Hide();
                    loginForm.Show();
                }
                catch
                {
                    MessageBox.Show("Username or email has been used!");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.Show();
        }

        private void Customer_Register_Load(object sender, EventArgs e)
        {

        }
    }
}