﻿using System;
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
    public partial class Customer_MainMenu : Form
    {
        BookStoreEntities ent = new BookStoreEntities();
        string userid;
        public Customer_MainMenu(string userid)
        {
            InitializeComponent();
            this.userid = userid;
        }

        private void Customer_MainMenu_Load(object sender, EventArgs e)
        {
            groupNewReleases.Enabled = false;
            groupRecommended.Enabled = false;
            groupBook.Enabled = false;
            txtName.Enabled = false;
            txtAge.Enabled = false;
            
            fillUserinfo(userid);
            refreshData();
            dataNewReleases.AutoResizeRows();
            groupAccountDetails.Enabled = false;
        }

        private void fillUserinfo(string code)
        {
            var query = from c in ent.Customers
                        where c.Customer_ID.Equals(code)
                        select c;

            var data = query.First();
            txtName.Text = data.Customer_Name;
            txtEmail.Text = data.Email;
            txtPhone.Text = data.Phone_Number;
            txtUsername.Text = data.Username;
            txtPassword.Text = data.Password;
            txtAddress.Text = data.Customer_Address;
            txtAge.Text = data.Birth_Date.Value.ToLongDateString();
            if (data.Gender.Equals("Female"))
            {
                rbFemale.Checked = true;
            }
            else
            {
                rbMale.Checked = true;
            }
            txtBalance.Text = Convert.ToString(data.Balance);
        }

        private string getPublisherName(string code)
        {
            var query = from c in ent.Publishers
                        where c.Publisher_ID.Equals(code)
                        select c.Publisher_Name;

            return query.ToList().First();
        }

        private void fillNewRealesesData()
        {
            var getValue = dataNewReleases.CurrentCell.Value.ToString();

            var query = from c in ent.Products
                        where c.Product_Title.Equals(getValue)
                        select c;

            var data = query.First();
            txtTitleNew.Text = data.Product_Title;
            txtPublisherNew.Text = getPublisherName(data.Publisher_ID);
            txtPriceNew.Text = Convert.ToString(data.Price);
            txtCategoryNew.Text = data.Category;
            txtPublishDateNew.Text = data.Date_Publish.Value.ToShortDateString();
            pictureNew.ImageLocation = data.Image_URL;
            pictureNew.SizeMode = PictureBoxSizeMode.AutoSize;
        }
        
        private void fillRecommendedData()
        {
            var getValue = dataRecommended.CurrentCell.Value.ToString();

            var query = from c in ent.Products
                        where c.Product_Title.Equals(getValue)
                        select c;

            var data = query.First();
            txtTitleRec.Text = data.Product_Title;
            txtPublisherRec.Text = getPublisherName(data.Publisher_ID);
            txtPriceRec.Text = Convert.ToString(data.Price);
            txtCategoryRec.Text = data.Category;
            txtPublishDateRec.Text = data.Date_Publish.Value.ToShortDateString();
            pictureRec.ImageLocation = data.Image_URL;
            pictureRec.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void fillBookData()
        {
            var getValue = dataBook.CurrentCell.Value.ToString();

            var query = from c in ent.Products
                        where c.Product_Title.Equals(getValue)
                        select c;

            var data = query.First();
            txtTitle.Text = data.Product_Title;
            txtPublisher.Text = getPublisherName(data.Publisher_ID);
            txtPrice.Text = Convert.ToString(data.Price);
            txtCategory.Text = data.Category;
            txtPublishDate.Text = data.Date_Publish.Value.ToShortDateString();
            pictureBook.ImageLocation = data.Image_URL;
            pictureBook.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void refreshData()
        {
            DateTime monthAgo = DateTime.Now.AddDays(-30);
            var query = from c in ent.Products
                        where c.Date_Publish > monthAgo
                        select new { BookTitle= c.Product_Title };
            dataNewReleases.DataSource = query.ToList();
        }

        private void dataNewReleases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillNewRealesesData();
        }

        private void dataRecommended_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillRecommendedData();
        }

        private void dataBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillBookData();
        }
    }
}
