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
        }

        private string getLastPublisher()
        {
            var query = from c in ent.Publishers
                        select c.Publisher_ID;
            return query.ToList().Last();
        }

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
            groupBoxPublisher.Enabled = false;
            groupBoxAccount.Enabled = false;
        }

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            counter = 0;
            groupBoxPublisher.Enabled = true;
            disableButtons();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (counter == 0)
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
                refreshPublisherData();
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
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            groupBoxAccount.Enabled = true;
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
