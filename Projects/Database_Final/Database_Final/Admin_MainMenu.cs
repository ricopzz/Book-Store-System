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
        string userid;
        int counter = 0;
        List<string> listOfPurchase = new List<string>();

        private void refreshTrHeaderData()
        {
            var query = from c in ent.TransactionHeaders
                        select new { TransactionID = c.Transaction_ID, TransactionDate = c.Transaction_Date, RequestID = c.Request_ID };
            dataTrHeader.DataSource = query.ToList();
        }

        private void refreshTrDetailsData()
        {
            var query = from c in ent.TransactionDetails
                        select new { TransactionID = c.Transaction_ID, ProductID = c.Product_ID, Quantity = c.Quantity, Price = c.Price };
            dataTrDetails.DataSource = query.ToList();
        }

        private string getStaffID(string code)
        {
            var query = from c in ent.Staffs
                        where c.Username.Equals(code)
                        select c.Staff_ID;
            return query.ToList().First();
        }

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
                        where c.Req_Status.Equals("REQUESTED")
                        || c.Req_Status.Equals("Accepted")
                        || c.Req_Status.Equals("On Process")
                        select new { RequestID = c.Request_ID, CustomerID = c.Customer_ID, ProductID = c.Product_ID, StaffID = c.Staff_ID, Quantity = c.Quantity, RequestDate = c.Request_Date, Status = c.Req_Status, PaymentType = c.Payment_Type, Price = c.price };
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

        private string getLastTr()
        {
            try
            {
                var query = from c in ent.TransactionHeaders
                            orderby c.Transaction_ID
                            select c.Transaction_ID;
                return query.ToList().Last();
            }
            catch
            {
                return "TR000000";
            }
        }

        private int getQuantityOfProduct(string code)
        {
            var query = from c in ent.Products
                        where c.Product_ID.Equals(code)
                        select c.Stock_Qty;

            return Convert.ToInt32(query.ToList().First());
        }

        private int getQuantityOfProductByName(string code)
        {
            var query = from c in ent.Products
                        where c.Product_Title.Equals(code)
                        select c.Stock_Qty;

            return Convert.ToInt32(query.ToList().First());
        }

        private int getQuantityOfRequest(string code, string rqcode)
        {
            var query = from c in ent.CustomerRequests
                        where c.Product_ID.Equals(code)
                        && c.Request_ID.Equals(rqcode)
                        select c.Quantity;

            return Convert.ToInt32(query.ToList().First());
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
            try
            {
                var query = from c in ent.Staffs
                            orderby c.Staff_ID
                            select c.Staff_ID;
                return query.ToList().Last();
            }
            catch
            {
                return "STF000";
            }
        }

        private string getLastBook()
        {
            try
            {
                var query = from c in ent.Products
                            orderby c.Product_ID
                            select c.Product_ID;
                return query.ToList().Last();
            }
            catch
            {
                return "PRD00000";
            }
        }

        private void refershCashierData()
        {
            var query = from c in ent.Products
                        select new { BookTitle = c.Product_Title };
            dataBooks.DataSource = query.ToList();
        }

        private void refreshStaffData()
        {
            var query = from c in ent.Staffs
                        select c;
            dataAccount.DataSource = query.ToList();
        }

        public Admin_MainMenu(string position,string userid)
        {
            this.position = position;
            this.userid = userid;
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
        private int getPrice(string code)
        {
            try
            {
                var query = from c in ent.Products
                            where c.Product_Title.Equals(code)
                            select c.Price;
                return Convert.ToInt32(query.ToList().First());
            }
            catch
            {
                return 0;
            }
        }

        private string getLastRequestID()
        {
            try
            {
                var query = from c in ent.CustomerRequests
                            orderby c.Request_ID
                            select c.Request_ID;
                string code = query.ToList().Last();
                return code;
            }
            catch
            {
                return "RQ00000";
            }
        }
        private string getProductID(string title)
        {
            var query = from c in ent.Products
                        where c.Product_Title.Equals(title)
                        select c.Product_ID;

            return query.ToList().First();
        }

        private void Admin_MainMenu_Load(object sender, EventArgs e)
        {
            if (position.Equals("Stock"))
            {
                tabAccount.Dispose();
                tabTransaction.Dispose();
                tabRequest.Dispose();
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
                tabTransaction.Dispose();
                tabRequest.Dispose();
            }
            else if (position.Equals("Cashier"))
            {
                tabPublisher.Dispose();
                tabBooks.Dispose();
                tabTransaction.Dispose();
                tabRequest.Dispose();
                tabAccount.Dispose();
            }
            
            groupBoxPublisher.Enabled = false;
            groupBoxAccount.Enabled = false;
            groupBoxBooks.Enabled = false;
            refreshRequestData();
            refreshStaffData();
            refreshBookData();
            refreshPublisherData();
            refreshTrDetailsData();
            refreshTrHeaderData();
            refershCashierData();
            fillPublisherBox();
            txtStaffID.Text = getStaffID(userid);
            txtStaffID.Enabled = false;
            qtySentNum.Enabled = false;
            btnCheckout.Enabled = false;
            txtCardNumber.Enabled = false;
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
                try
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
                catch
                {
                    MessageBox.Show("You can not remove yourself!");
                }
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
                        MessageBox.Show("Staff username or email has been used!");
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
                        MessageBox.Show("Staff username or email has been used!");
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

        private void dataRequest_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            qtySentNum.Maximum = getQuantityOfProduct(dataRequest.CurrentRow.Cells[2].Value.ToString());
            boxStatus.SelectedIndex = -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (qtySentNum.Enabled == false && boxStatus.SelectedIndex==0)
            {
                string productid = dataRequest.CurrentRow.Cells[2].Value.ToString();
                string requestid = dataRequest.CurrentRow.Cells[0].Value.ToString();
                var query = (from c in ent.CustomerRequests
                             where c.Product_ID.Equals(productid)
                             && c.Request_ID.Equals(requestid)
                             select c).First();

                query.Req_Status = "Accepted";
                ent.SaveChanges();
                MessageBox.Show("Updated!");
                refreshRequestData();
                boxStatus.SelectedIndex = -1;
            }
            else if(boxStatus.SelectedIndex==1)
            {
                string productid = dataRequest.CurrentRow.Cells[2].Value.ToString();
                string requestid = dataRequest.CurrentRow.Cells[0].Value.ToString();
                if (Convert.ToInt32(qtySentNum.Value) > Convert.ToInt32(dataRequest.CurrentRow.Cells[4].Value.ToString()))
                {
                    MessageBox.Show("Quantity sent is too many!");
                }
                else if (Convert.ToInt32(qtySentNum.Value) <= Convert.ToInt32(dataRequest.CurrentRow.Cells[4].Value.ToString()))
                {
                    int id = Int32.Parse(getLastTr().Substring(2)) + 1;
                    String trid = "TR" + id.ToString().PadLeft(6, '0');

                    var data = new TransactionHeader
                    {
                        Transaction_ID = trid,
                        Transaction_Date = DateTime.Now,
                        Request_ID = dataRequest.CurrentRow.Cells[0].Value.ToString()
                    };
                    ent.TransactionHeaders.Add(data);
                    ent.SaveChanges();

                    var data2 = new TransactionDetail
                    {
                        Transaction_ID = trid,
                        Product_ID = dataRequest.CurrentRow.Cells[2].Value.ToString(),
                        Quantity = Convert.ToInt32(qtySentNum.Value.ToString()),
                        Price = Convert.ToInt32(dataRequest.CurrentRow.Cells[8].Value.ToString())
                    };
                    ent.TransactionDetails.Add(data2);
                    ent.SaveChanges();

                    refreshTrDetailsData();
                    refreshTrHeaderData();

                    var query = (from c in ent.CustomerRequests
                                 where c.Product_ID.Equals(productid)
                                 && c.Request_ID.Equals(requestid)
                                 select c).First();
                    //Console.WriteLine(getQuantityOfRequest(dataRequest.CurrentRow.Cells[2].Value.ToString(), dataRequest.CurrentRow.Cells[0].Value.ToString()));
                    query.Quantity = getQuantityOfRequest(dataRequest.CurrentRow.Cells[2].Value.ToString(), dataRequest.CurrentRow.Cells[0].Value.ToString()) - Convert.ToInt32(qtySentNum.Value);
                    if(query.Quantity == 0)
                    {
                        query.Req_Status = "Done";
                    }
                    else
                    {
                        query.Req_Status = "On Process";
                    }
                    
                    query.Staff_ID = txtStaffID.Text;
                    ent.SaveChanges();
                    refreshRequestData();
                    boxStatus.SelectedIndex = -1;

                    var query2 = (from c in ent.Products
                                 where c.Product_ID.Equals(productid)
                                 select c).First();

                    query2.Stock_Qty = getQuantityOfProduct(dataRequest.CurrentRow.Cells[2].Value.ToString()) - Convert.ToInt32(qtySentNum.Value);
                    ent.SaveChanges();
                    refreshBookData();
                    MessageBox.Show("Updated!");
                }
            }
            else
            {
                MessageBox.Show("Please select request status!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boxStatus.SelectedIndex == 1)
            {
                qtySentNum.Enabled = true;
            }
            else
            {
                qtySentNum.Enabled = false;
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login_Form login = new Login_Form();
            login.Show();
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            var title = dataBooks.CurrentRow.Cells[0].Value.ToString();
            if (listOfPurchase.Contains(title))
            {
                MessageBox.Show("Book is already in cart!");
            }
            else
            {
                listOfPurchase.Add(title);
                MessageBox.Show("Added to cart!");
                DataTable dt = new DataTable();
                dt.Columns.Add(new DataColumn("BookTitle", typeof(string)));
                dt.Columns.Add(new DataColumn("Quantity", typeof(int)));
                dt.Columns.Add(new DataColumn("Price", typeof(int)));
                dt.Columns.Add(new DataColumn("Subtotal", typeof(int)));
                dataCart.DataSource = dt;
                foreach (string txt in listOfPurchase)
                {
                    dt.Rows.Add(txt, 1, getPrice(txt), getPrice(txt));
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                dataCart.CurrentRow.Cells[1].Value = qtyCashierNum.Value;
                dataCart.CurrentRow.Cells[3].Value = qtyCashierNum.Value * Convert.ToInt32(dataCart.CurrentRow.Cells[2].Value);
            }
            catch
            {
                MessageBox.Show("No book selected");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var value = dataCart.CurrentRow.Cells[0].Value.ToString();
                listOfPurchase.Remove(value);
                foreach (DataGridViewCell oneCell in dataCart.SelectedCells)
                {
                    if (oneCell.Selected)
                        dataCart.Rows.RemoveAt(oneCell.RowIndex);
                }
            }
            catch
            {
                MessageBox.Show("Cart is Empty!");
            }
        }

        private void rbStoreCredit_CheckedChanged(object sender, EventArgs e)
        {
            txtCardNumber.Enabled = false;
            btnCheckout.Enabled = true;
        }

        private void rbCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            txtCardNumber.Enabled = true;
            btnCheckout.Enabled = true;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (listOfPurchase.Count == 0)
            {
                MessageBox.Show("Cart is empty!");
            }
            else
            {
                string productname = dataCart.CurrentRow.Cells[0].Value.ToString();
                int id = Int32.Parse(getLastRequestID().Substring(2)) + 1;
                String rqid = "RQ" + id.ToString().PadLeft(5, '0');
                string paymentmethod = "";
                string creditcard = "";

                if (rbCash.Checked == true)
                {
                    paymentmethod = "Cash";
                    creditcard = "";
                }
                else
                {
                    paymentmethod = "Credit Card";
                    creditcard = txtCardNumber.Text;
                }

                for (int i = 0; i < listOfPurchase.Count; i++)
                {
                    Console.WriteLine(listOfPurchase[i]);
                    var datareq = new CustomerRequest
                    {
                        Request_ID = rqid,
                        Customer_ID = "CST00000", // cst00000 = guest
                        Req_Status = "Done",
                        Request_Date = DateTime.Now,
                        Product_ID = getProductID(listOfPurchase[i]),
                        Quantity = Convert.ToInt32(dataCart.CurrentRow.Cells[1].Value.ToString()),
                        price = getPrice(listOfPurchase[i]),
                        Payment_Type = paymentmethod,
                        cardnumber = creditcard
                    };
                    ent.CustomerRequests.Add(datareq);
                    ent.SaveChanges();
                }

                refreshTrDetailsData();
                refreshTrHeaderData();

                var query2 = (from c in ent.Products
                              where c.Product_Title.Equals(productname)
                              select c).First();

                query2.Stock_Qty = getQuantityOfProductByName(dataCart.CurrentRow.Cells[0].Value.ToString()) - Convert.ToInt32(dataCart.CurrentRow.Cells[1].Value.ToString());
                ent.SaveChanges();
                refreshBookData();
                MessageBox.Show("Purchase done!");
                dataCart.DataSource = null;
                refreshRequestData();
                refreshBookData();
                rbCash.Checked = false;
                rbCreditCard.Checked = false;
                btnCheckout.Enabled = false;
            }
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void btnAddVoucher_Click(object sender, EventArgs e)
        {
            
        }
    }
}