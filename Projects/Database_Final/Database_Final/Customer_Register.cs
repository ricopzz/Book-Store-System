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
        BookStoreEntities ent = new BookStoreEntities();

        public Customer_Register()
        {
            InitializeComponent();
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
            else if (boxJob.SelectedIndex == -1 || boxJob.SelectedItem == "")
            {
                MessageBox.Show("Please choose your job!");
            }
            else
            {
                String gender;
                if (rbFemale.Checked) gender = "Female";
                else gender = "Male";

                var data = new Customer
                {
                    Customer_ID = "default",
                    Customer_Name = txtName.Text,
                    Customer_Address = txtAddress.Text,
                    Customer_Type = boxJob.Text,
                    Age = DateTime.Now.Year - birthDatePicker.Value.Year,
                    Phone_Number = txtPhone.Text,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    Email = txtEmail.Text,
                    Gender = gender
                };
                ent.Customers.Add(data);
                ent.SaveChanges();
                MessageBox.Show("Success Registering");
            }
        }
    }
}
           
    
