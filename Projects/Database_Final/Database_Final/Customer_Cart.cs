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
    public partial class Customer_Cart : Form
    {
        BookStoreDBEntities ent = new BookStoreDBEntities();
        string userid;
        List<string> purchasecart = new List<string>();
        public Customer_Cart(string userid, List<string> purchasecart)
        {
            InitializeComponent();
            this.userid = userid;
            this.purchasecart = purchasecart;
        }
        
        private int getPrice(string code)
        {
            var query = from c in ent.Products
                        where c.Product_Title.Equals(code)
                        select c.Price;
            return Convert.ToInt32(query.ToList().First());
        }

        private string getLastRequestID()
        {
            try
            {
                var query = from c in ent.CustomerRequestHeaders
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

        private void txtCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private string getProductID(string title)
        {
            var query = from c in ent.Products
                        where c.Product_Title.Equals(title)
                        select c.Product_ID;

            return query.ToList().First();
        }

        private string getCustomerBalance(string userid)
        {
            var query = from c in ent.Customers
                        where c.Customer_ID.Equals(userid)
                        select c.Balance;

            return Convert.ToString(query.ToList().First());
        }

        private void Customer_Cart_Load(object sender, EventArgs e)
        {
            btnCheckout.Enabled = false;
            txtRequestID.Enabled = false;
            txtBalance.Enabled = false;
            txtRequestDate.Enabled = false;
            txtCardNumber.Enabled = false;
            txtBalance.Text = getCustomerBalance(userid);

            int id = Int32.Parse(getLastRequestID().Substring(2)) + 1;
            String rqid = "RQ" + id.ToString().PadLeft(5, '0');
            txtRequestID.Text = rqid;
            txtRequestDate.Text = DateTime.Now.ToLongDateString();

            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("BookTitle", typeof(string)));
            dt.Columns.Add(new DataColumn("Quantity", typeof(int)));
            dt.Columns.Add(new DataColumn("Price", typeof(int)));
            dt.Columns.Add(new DataColumn("Subtotal", typeof(int)));
            dataCart.DataSource = dt;
            foreach(string txt in purchasecart)
            {
                dt.Rows.Add(txt,1,getPrice(txt),getPrice(txt));
            }
        }

        private void rbCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            txtCardNumber.Enabled = true;
            btnCheckout.Enabled = true;
        }

        private void rbStoreCredit_CheckedChanged(object sender, EventArgs e)
        {
            txtCardNumber.Enabled = false;
            btnCheckout.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_MainMenu mainmenu = new Customer_MainMenu(userid,purchasecart);
            mainmenu.Show();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                dataCart.CurrentRow.Cells[1].Value = qtyNum.Value;
                dataCart.CurrentRow.Cells[3].Value = qtyNum.Value * Convert.ToInt32(dataCart.CurrentRow.Cells[2].Value);
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
                purchasecart.Remove(value);
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

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataCart.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataCart.Rows[i].Cells[3].Value);
            }
            if (purchasecart.Count == 0)
            {
                MessageBox.Show("Your cart is empty!");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("You will be charged the amount of "+sum, "Test", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (rbStoreCredit.Checked == true)
                    {
                        if (Convert.ToInt32(txtBalance.Text) > sum)
                        {
                            var data = new CustomerRequestHeader
                            {
                                Request_ID = txtRequestID.Text,
                                Customer_ID = userid,
                                Request_Date = DateTime.Now,
                                Payment_Type = "Store Credit",
                                cardnumber = null
                            };
                            ent.CustomerRequestHeaders.Add(data);
                            ent.SaveChanges();

                            for (int i = 0; i < purchasecart.Count; i++)
                            {
                                Console.WriteLine(purchasecart[i]);
                                Console.WriteLine(getProductID(purchasecart[i]));

                                var detaildata = new CustomerRequestDetail
                                {
                                    Request_ID = txtRequestID.Text,
                                    Product_ID = getProductID(purchasecart[i]),
                                    Req_Status = "REQUESTED",
                                    Quantity = Convert.ToInt32(dataCart.Rows[i].Cells[1].Value.ToString()),
                                    Price = getPrice(purchasecart[i])
                                };
                                ent.CustomerRequestDetails.Add(detaildata);
                                ent.SaveChanges();
                            }
                            var query = (from c in ent.Customers
                                        where c.Customer_ID.Equals(userid)
                                        select c).First();

                            query.Balance = Convert.ToInt32(getCustomerBalance(userid)) - sum;
                            ent.SaveChanges();
                            MessageBox.Show("Your order will be processed soon. Thanks for your order!");
                            this.Hide();
                            Customer_MainMenu menu = new Customer_MainMenu(userid);
                            menu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Insufficient balance!");
                        }
                    }
                    else
                    {
                        var data = new CustomerRequestHeader
                        {
                            Request_ID = txtRequestID.Text,
                            Customer_ID = userid,
                            Request_Date = DateTime.Now,
                            Payment_Type = "Credit Card",
                            cardnumber = txtCardNumber.Text
                        };
                        ent.CustomerRequestHeaders.Add(data);
                        ent.SaveChanges();

                        for (int i = 0; i < purchasecart.Count; i++)
                        {
                            Console.WriteLine(purchasecart[i]);
                            Console.WriteLine(getProductID(purchasecart[i]));

                            var detaildata = new CustomerRequestDetail
                            {
                                Request_ID = txtRequestID.Text,
                                Product_ID = getProductID(purchasecart[i]),
                                Req_Status = "REQUESTED",
                                Quantity = Convert.ToInt32(dataCart.Rows[i].Cells[1].Value.ToString()),
                                Price = getPrice(purchasecart[i])
                            };
                            ent.CustomerRequestDetails.Add(detaildata);
                            ent.SaveChanges();
                        }
                        MessageBox.Show("Your order will be processed soon. Thanks for your order!");
                        this.Hide();
                        Customer_MainMenu menu = new Customer_MainMenu(userid);
                        menu.Show();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
            
        }

        private void dataCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            qtyNum.ResetText();
        }
    }
}
