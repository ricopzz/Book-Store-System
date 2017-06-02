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
        BookStoreDBEntities ent = new BookStoreDBEntities();

        int counter = 0;

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void refreshRequestData()
        {
            var query = from c in ent.CustomerRequests
                        select new { RequestID = c.Request_ID, CustomerID = c.Customer_ID, ProductID = c.Product_ID, StaffID = c.Staff_ID, Quantity = c.Quantity, RequestDate = c.Request_Date, Status = c.Req_Status };
            dataRequest.DataSource = query.ToList();
        }

        private void fillPublisherBox()
        {
            using (BookStoreDBEntities c = new BookStoreDBEntities())
            {
                boxPublisher.DataSource = c.Publishers.ToList();
                boxPublisher.ValueMember = "Publisher_ID";
                boxPublisher.DisplayMember = "Publisher_Name";
                boxPublisher.SelectedIndex = -1;
            }
        }

        private string getPublisherName(string code)
        {
            var query = from c in ent.Publishers
                        where c.Publisher_ID.Equals(code)
                        select c.Publisher_Name;

            return query.ToList().ToString();
        }

        private string getPublisherID(string code)
        {
            var query = from c in ent.Publishers
                        where c.Publisher_Name.Equals(code)
                        select c.Publisher_ID;

            return query.ToList().ToString();
        }

        private void disableButtons()
        {
            btnAddPublisher.Enabled = false;
            btnDeletePublisher.Enabled = false;
            btnUpdatePublisher.Enabled = false;
            btnAddAccount.Enabled = false;
            btnDeleteAccount.Enabled = false;
            btnUpdateAccount.Enabled = false;
            btnAddBook.Enabled = false;
            btnDeleteBook.Enabled = false;
            btnUpdateBook.Enabled = false;
        }
        
        private void enableButtons()
        {
            btnAddPublisher.Enabled = true;
            btnDeletePublisher.Enabled = true;
            btnUpdatePublisher.Enabled = true;
            btnAddAccount.Enabled = true;
            btnDeleteAccount.Enabled = true;
            btnUpdateAccount.Enabled = true;
            btnAddBook.Enabled = true;
            btnDeleteBook.Enabled = true;
            btnUpdateBook.Enabled = true;
        }

        private void resetTextBox()
        {
            txtPublisherName.ResetText();
            txtPublisherAddress.ResetText();
            txtPhoneNumber.ResetText();
            txtAccountName.ResetText();
            txtAccountAddress.ResetText();
            txtUsername.ResetText();
            txtPassword.ResetText();
            rbMale.Checked = false;
            rbFemale.Checked = false;
            boxPosition.SelectedIndex = -1;
            txtEmail.ResetText();
            txtTitle.ResetText();
            priceNum.Value = 2500;
            qtyNum.Value = 1;
            boxCategory.SelectedIndex = -1;
            boxPublisher.SelectedIndex = -1;
            txtURL.ResetText();
        }

        private string getLastPublisher()
        {
            try
            {
                var query = from c in ent.Publishers
                            orderby c.Publisher_ID
                            select c.Publisher_ID;
                return query.ToList().Last();
            }
            catch
            {
                return "PBL0000";
            }
        }

        private string getLastAccount()
        {
            var query = from c in ent.Staffs
                        orderby c.Staff_ID
                        select c.Staff_ID;
            return query.ToList().Last();
        }

        private string getLastBook()
        {
            var query = from c in ent.Products
                        orderby c.Product_ID
                        select c.Product_ID;
            return query.ToList().Last();
        }

        private void refreshStaffData()
        {
            var query = from c in ent.Staffs
                        select c;
            dataAccount.DataSource = query.ToList();
        }

        public Admin_MainMenu(string position)
        {
            this.position = position;
            InitializeComponent();
        }

        private void refreshPublisherData()
        {
            var query = from c in ent.Publishers
                        select c;
            dataPublisher.DataSource = query.ToList();
        }

        private void refreshBookData()
        {
            var query = from c in ent.Products
                        orderby c.Product_ID
                        select c;
            dataBook.DataSource = query.ToList();
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
                tabBooks.Dispose();
                tabAccount.Dispose();
            }
            else if (position.Equals("Manager"))
            {
                tabPublisher.Dispose();
                tabBooks.Dispose();
            }
            
            groupBoxPublisher.Enabled = false;
            groupBoxAccount.Enabled = false;
            groupBoxBooks.Enabled = false;
            refreshRequestData();
            refreshStaffData();
            refreshBookData();
            refreshPublisherData();
            fillPublisherBox();
        }

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            counter = 0;
            groupBoxPublisher.Enabled = true;
            disableButtons();
            tabAccount.IsAccessible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                if(txtPublisherName.Text == "" || txtPublisherName.Text == "" || txtPhoneNumber.Text == "")
                {
                    MessageBox.Show("Please fill all data!");
                }
                else
                {
                    int id = Int32.Parse(getLastPublisher().Substring(3)) + 1;
                    String pubid = "PBL" + id.ToString().PadLeft(4, '0');

                    var data = new Publisher
                    {
                        Publisher_ID = pubid,
                        Publisher_Name = txtPublisherName.Text,
                        Publisher_Address = txtPublisherAddress.Text,
                        Phone_Number = txtPhoneNumber.Text
                    };
                    ent.Publishers.Add(data);
                    ent.SaveChanges();
                    MessageBox.Show("Added new publisher!");
                    resetTextBox();
                    groupBoxPublisher.Enabled = false;
                    enableButtons();
                    refreshPublisherData();
                    fillPublisherBox();
                }
            }
            else
            {
                if (txtPublisherName.Text == "" || txtPublisherName.Text == "" || txtPhoneNumber.Text == "")
                {
                    MessageBox.Show("Please fill all data!");
                }
                else
                {
                    String code = dataPublisher.CurrentRow.Cells[0].Value.ToString();
                    var query = (from c in ent.Publishers
                                 where c.Publisher_ID.Equals(code)
                                 select c).First();

                    query.Publisher_Name = txtPublisherName.Text;
                    query.Phone_Number = txtPhoneNumber.Text;
                    query.Publisher_Address = txtPublisherAddress.Text;
                    MessageBox.Show("Changes saved!");
                    ent.SaveChanges();
                    resetTextBox();
                    groupBoxPublisher.Enabled = false;
                    enableButtons();
                    refreshPublisherData();
                    fillPublisherBox();
                }
            }
        }

        private void btnUpdatePublisher_Click(object sender, EventArgs e)
        {
            if (dataPublisher.SelectedCells.Count == 0)
            {
                MessageBox.Show("No data selected!");
            }
            else {
                counter = 1;
                groupBoxPublisher.Enabled = true;
                txtPhoneNumber.Text = dataPublisher.CurrentRow.Cells[3].Value.ToString();
                txtPublisherName.Text = dataPublisher.CurrentRow.Cells[1].Value.ToString();
                txtPublisherAddress.Text = dataPublisher.CurrentRow.Cells[2].Value.ToString();
                disableButtons();
            }
        }

        private void btnDeletePublisher_Click(object sender, EventArgs e)
        {
            if(dataPublisher.SelectedCells.Count == 0)
            {
                MessageBox.Show("No data selected!");
            }
            else
            {
                String id = dataPublisher.CurrentRow.Cells[0].Value.ToString();
                var query = from c in ent.Publishers
                            where c.Publisher_ID.Equals(id)
                            select c;
                ent.Publishers.Remove(query.First());
                ent.SaveChanges();
                MessageBox.Show("Publisher deleted!");
                groupBoxPublisher.Enabled = false;
                refreshPublisherData();
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetTextBox();
            groupBoxPublisher.Enabled = false;
            enableButtons();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            counter = 0;
            groupBoxAccount.Enabled = true;
            disableButtons();
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            if (dataAccount.SelectedCells.Count == 0)
            {
                MessageBox.Show("No data selected!");
            }
            else
            {
              groupBoxAccount.Enabled = true;
              counter = 1;
              txtAccountName.Enabled = false;
              txtUsername.Enabled = false;
              birthDatePicker.Enabled = false;
              rbMale.Enabled = false;
              rbFemale.Enabled = false;

              txtAccountName.Text = dataAccount.CurrentRow.Cells[1].Value.ToString();
              txtAccountAddress.Text = dataAccount.CurrentRow.Cells[2].Value.ToString();
              txtEmail.Text = dataAccount.CurrentRow.Cells[6].Value.ToString();
              txtUsername.Text = dataAccount.CurrentRow.Cells[4].Value.ToString();
              txtPassword.Text = dataAccount.CurrentRow.Cells[5].Value.ToString();
              birthDatePicker.Text = dataAccount.CurrentRow.Cells[8].Value.ToString();
              if (dataAccount.CurrentRow.Cells[3].Value.ToString().Equals("Male"))
              {
                  rbMale.Checked = true;
              }
              else
              {
                  rbFemale.Checked = true;
              }
              boxPosition.Text = dataAccount.CurrentRow.Cells[7].Value.ToString();
              disableButtons();
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (dataPublisher.SelectedCells.Count == 0)
            {
                MessageBox.Show("No data selected!");
            }
            else
            {
                String id = dataAccount.CurrentRow.Cells[0].Value.ToString();
                var query = from c in ent.Staffs
                            where c.Staff_ID.Equals(id)
                            select c;
                ent.Staffs.Remove(query.First());
                ent.SaveChanges();
                MessageBox.Show("Staff deleted!");
                groupBoxAccount.Enabled = false;
                refreshStaffData();
            }
        }

        private void btnSaveAccount_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                if (txtAccountName.Text == "" || txtAccountAddress.Text == "" || txtEmail.Text == "" || txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Please fill all fields!");
                }
                else if (rbFemale.Checked == false && rbMale.Checked == false)
                {
                    MessageBox.Show("Please choose gender!");
                }
                else if (boxPosition.SelectedIndex == -1)
                {
                    MessageBox.Show("Please choose position!");
                }
                else
                {
                    try
                    {
                        String gender;
                        if (rbFemale.Checked) gender = "Female";
                        else gender = "Male";

                        int id = Int32.Parse(getLastAccount().Substring(3)) + 1;
                        String staffid = "STF" + id.ToString().PadLeft(3, '0');

                        var data = new Staff
                        {
                            Staff_ID = staffid,
                            Staff_Name = txtAccountName.Text,
                            Staff_Address = txtAccountAddress.Text,
                            Email = txtEmail.Text,
                            Gender = gender,
                            Birth_Date = birthDatePicker.Value,
                            Username = txtUsername.Text,
                            Password = txtPassword.Text,
                            Position = boxPosition.SelectedItem.ToString()
                        };
                        ent.Staffs.Add(data);
                        ent.SaveChanges();
                        MessageBox.Show("Added new staff!");
                        resetTextBox();
                        groupBoxAccount.Enabled = false;
                        enableButtons();
                        refreshStaffData();
                        resetTextBox();
                    }
                    catch
                    {
                        MessageBox.Show("Staff uesrname or email has been uesd!");
                    }
                }
            }
            else
            {
                if (txtAccountName.Text == "" || txtAccountAddress.Text == "" || txtEmail.Text == "" || txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Please fill all fields!");
                }
                else if(rbFemale.Checked == false && rbMale.Checked == false){
                    MessageBox.Show("Please choose gender!");
                }
                else if(boxPosition.SelectedIndex == -1)
                {
                    MessageBox.Show("Please choose position!");
                }
                else
                {
                    try
                    {
                        String code = dataAccount.CurrentRow.Cells[0].Value.ToString();
                        var query = (from c in ent.Staffs
                                     where c.Staff_ID.Equals(code)
                                     select c).First();

                        query.Staff_Address = txtAccountAddress.Text;
                        query.Username = txtUsername.Text;
                        query.Password = txtPassword.Text;
                        query.Email = txtEmail.Text;
                        query.Position = boxPosition.SelectedItem.ToString();

                        MessageBox.Show("Changes saved!");
                        resetTextBox();
                        ent.SaveChanges();
                        groupBoxAccount.Enabled = false;
                        enableButtons();
                        refreshStaffData();
                        resetTextBox();
                    }
                    catch
                    {
                        MessageBox.Show("Staff uesrname or email has been uesd!");
                    }
                }
            }
        }

        private void btnCancelAccount_Click(object sender, EventArgs e)
        {
            groupBoxAccount.Enabled = false;
            resetTextBox();
            enableButtons();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            counter = 0;
            disableButtons();
            groupBoxBooks.Enabled = true;
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            counter = 1;
            disableButtons();
            groupBoxBooks.Enabled = true;
            txtTitle.Text = dataBook.CurrentRow.Cells[1].Value.ToString();
            txtURL.Text = dataBook.CurrentRow.Cells[7].Value.ToString();
            publishDatepicker.Text = dataBook.CurrentRow.Cells[6].Value.ToString();
            qtyNum.Value = Convert.ToInt32(dataBook.CurrentRow.Cells[4].Value.ToString());
            priceNum.Value = Convert.ToInt32(dataBook.CurrentRow.Cells[5].Value.ToString());
            boxCategory.Text = dataBook.CurrentRow.Cells[3].Value.ToString();
            boxPublisher.SelectedValue = dataBook.CurrentRow.Cells[2].Value;
        }

        private void btnCancelBook_Click(object sender, EventArgs e)
        {
            resetTextBox();
            enableButtons();
            groupBoxBooks.Enabled = false;
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dataBook.SelectedCells.Count == 0)
            {
                MessageBox.Show("No data selected!");
            }
            else
            {
                String id = dataBook.CurrentRow.Cells[0].Value.ToString();
                var query = from c in ent.Products
                            where c.Product_ID.Equals(id)
                            select c;
                ent.Products.Remove(query.First());
                ent.SaveChanges();
                MessageBox.Show("Book deleted!");
                groupBoxBooks.Enabled = false;
                refreshBookData();
            }
        }

        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            if (counter == 0)
            {
                if(txtTitle.Text == "" || txtURL.Text == "")
                {
                    MessageBox.Show("Please fill all fields!");
                }
                else if(boxCategory.SelectedIndex == -1)
                {
                    MessageBox.Show("Please choose category!");
                }
                else if(boxPublisher.SelectedIndex == -1)
                {
                    MessageBox.Show("Please choose publisher!");
                }
                else
                {
                    try
                    {
                        int id = Int32.Parse(getLastBook().Substring(3)) + 1;
                        String prodid = "PRD" + id.ToString().PadLeft(5, '0');

                        var data = new Product
                        {
                            Product_ID = prodid,
                            Product_Title = txtTitle.Text,
                            Publisher_ID = boxPublisher.SelectedValue.ToString(),
                            Category = boxCategory.SelectedItem.ToString(),
                            Date_Publish = publishDatepicker.Value,
                            Stock_Qty = Convert.ToInt32(qtyNum.Value),
                            Price = Convert.ToInt32(priceNum.Value),
                            Image_URL = txtURL.Text
                        };
                        ent.Products.Add(data);
                        ent.SaveChanges();
                        MessageBox.Show("Added new book!");
                        resetTextBox();
                        groupBoxBooks.Enabled = false;
                        enableButtons();
                        refreshBookData();
                    }
                    catch
                    {
                        MessageBox.Show("Duplicate Book's Title!");
                    }
                }
            }
            else if(counter == 1)
            {
                if (txtTitle.Text == "" || txtURL.Text == "")
                {
                    MessageBox.Show("Please fill all fields!");
                }
                else if (boxCategory.SelectedIndex == -1)
                {
                    MessageBox.Show("Please choose category!");
                }
                else if (boxPublisher.SelectedIndex == -1)
                {
                    MessageBox.Show("Please choose publisher!");
                }
                else
                {
                    try
                    {
                        String code = dataBook.CurrentRow.Cells[0].Value.ToString();
                        var query = (from c in ent.Products
                                     where c.Product_ID.Equals(code)
                                     select c).First();

                        query.Product_Title = txtTitle.Text;
                        query.Publisher_ID = boxPublisher.SelectedValue.ToString();
                        query.Category = boxCategory.SelectedItem.ToString();
                        query.Stock_Qty = Convert.ToInt32(qtyNum.Value);
                        query.Price = Convert.ToInt32(priceNum.Value);
                        query.Image_URL = txtURL.Text;
                        query.Date_Publish = publishDatepicker.Value;

                        MessageBox.Show("Changes saved!");
                        ent.SaveChanges();
                        resetTextBox();
                        groupBoxBooks.Enabled = false;
                        enableButtons();
                        refreshBookData();
                    }
                    catch
                    {
                        MessageBox.Show("Duplicate Book's Title");
                    }
                }
            }
        }
    }
}
