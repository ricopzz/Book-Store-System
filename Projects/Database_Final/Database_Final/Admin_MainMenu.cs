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

        int counter = 0;

        private void disableButtons()
        {
            btnAddPublisher.Enabled = false;
            btnDeletePublisher.Enabled = false;
            btnUpdatePublisher.Enabled = false;
        }

        private void resetTextBox()
        {
            txtPublisherName.ResetText();
            txtPublisherAddress.ResetText();
            txtPhoneNumber.ResetText();
            txtAccountName.ResetText();
            txtAccountAddress.ResetText();
            txtAge.ResetText();
            txtUsername.ResetText();
            txtPassword.ResetText();
            rbMale.Checked = false;
            rbFemale.Checked = false;
            boxPosition.SelectedIndex = -1;
            txtEmail.ResetText();
            txtAge.ResetText();
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
            groupBoxPublisher.Enabled = false;
            groupBoxAccount.Enabled = false;
            refreshStaffData();
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
                    btnAddPublisher.Enabled = true;
                    btnDeletePublisher.Enabled = true;
                    btnUpdatePublisher.Enabled = true;
                    refreshPublisherData();
                }
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
                resetTextBox();
                groupBoxPublisher.Enabled = false;
                btnAddPublisher.Enabled = true;
                btnDeletePublisher.Enabled = true;
                btnUpdatePublisher.Enabled = true;
                refreshPublisherData();
            }
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
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

        private void btnAddDelete_Click(object sender, EventArgs e)
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
            btnAddPublisher.Enabled = true;
            btnDeletePublisher.Enabled = true;
            btnUpdatePublisher.Enabled = true;
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            groupBoxAccount.Enabled = true;
            btnAddAccount.Enabled = false;
            btnDeleteAccount.Enabled = false;
            btnUpdateAccount.Enabled = false;
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
                txtAge.Enabled = false;
                rbMale.Enabled = false;
                rbFemale.Enabled = false;
                
                txtAccountName.Text = dataAccount.CurrentRow.Cells[1].Value.ToString();
                txtAccountAddress.Text = dataAccount.CurrentRow.Cells[2].Value.ToString();
                txtEmail.Text = dataAccount.CurrentRow.Cells[7].Value.ToString();
                txtUsername.Text = dataAccount.CurrentRow.Cells[5].Value.ToString();
                txtPassword.Text = dataAccount.CurrentRow.Cells[6].Value.ToString();
                txtAge.Text = dataAccount.CurrentRow.Cells[4].Value.ToString();
                if (dataAccount.CurrentRow.Cells[3].Value.ToString().Equals("Male")){
                    rbMale.Checked = true;
                }
                else
                {
                    rbFemale.Checked = true;
                }
                boxPosition.Text = dataAccount.CurrentRow.Cells[8].Value.ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (counter == 0)
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
                        Age = Int32.Parse(txtAge.Text),
                        Username = txtUsername.Text,
                        Password = txtPassword.Text,
                        Position = boxPosition.SelectedItem.ToString()
                    };
                    ent.Staffs.Add(data);
                    ent.SaveChanges();
                    MessageBox.Show("Added new staff!");
                    resetTextBox();
                    groupBoxAccount.Enabled = false;
                    btnAddAccount.Enabled = true;
                    btnDeleteAccount.Enabled = true;
                    btnUpdateAccount.Enabled = true;
                    refreshStaffData();
                    resetTextBox();
                }
                catch
                {
                    MessageBox.Show("Please fill all fields!");
                }
            }
            else
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
                groupBoxAccount.Enabled = false;
                btnAddAccount.Enabled = true;
                btnDeleteAccount.Enabled = true;
                btnUpdateAccount.Enabled = true;
                refreshStaffData();
                resetTextBox();
            }
        }

        private void btnCancelAccount_Click(object sender, EventArgs e)
        {
            groupBoxAccount.Enabled = false;
            resetTextBox();
            btnAddAccount.Enabled = true;
            btnDeleteAccount.Enabled = true;
            btnUpdateAccount.Enabled = true;
        }
    }
}
