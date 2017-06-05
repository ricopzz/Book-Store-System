using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Database_Final
{
    public partial class VerifyCode : Form
    {
        
        public VerifyCode()
        {
            InitializeComponent();
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            string code = new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
            return code;
        }

        string code = RandomString(5);

        public void emailSender(string mssage)
        {
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("database.bookstore@gmail.com", "bookstore12");

            MailMessage mm = new MailMessage("database.bookstore@gmail.com", txtEmail.Text, "Welcome to EAD Book Store!", "Welcome, here is your veification code : "+mssage);
            mm.BodyEncoding = UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.Send(mm);
            MessageBox.Show("Email Sent!");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtCode.Text != code)
            {
                MessageBox.Show("Invalid Verification Code");
                txtCode.Text = "";
                this.Dispose();
                Login_Form login = new Login_Form();
                login.Show();
            }
            else
            {
                MessageBox.Show("Account has been verified");
                BookStoreDBEntities ent = new BookStoreDBEntities();
                var query = (from c in ent.Customers
                             where c.Email.Equals(txtEmail.Text)
                             select c
                             ).First();

                query.Status = "Verified";
                ent.SaveChanges();
                this.Dispose();
                Login_Form login = new Login_Form();
                login.Show();
            }
        }

        private void VerifyCode_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookStoreDBEntities ent = new BookStoreDBEntities();
            var query = from c in ent.Customers
                        where c.Email.Equals(txtEmail.Text)
                        select c;
            if (query.ToList().Count() == 0)
            {
                MessageBox.Show("Email not found!");
            }
            else
            {
                emailSender(code);
                panel2.Hide();
                panel1.Show();

                txtCode.Text = "";
            }
        }
    }
}
