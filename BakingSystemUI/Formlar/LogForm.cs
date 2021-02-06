using BakingSystemUI.Core;
using BakingSystemUI.Data;
using BakingSystemUI.Models;
using BakingSystemUI.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BakingSystemUI.Forms
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
            
            regLogControl1.btn_submit.Text = "Register";
            regLogControl2.btn_submit.Text = "Login";
            regLogControl1.btn_submit.Click += btn_register_clicked;
            regLogControl2.btn_submit.Click += btn_login_clicked;
        }
        
        private void btn_register_clicked(object sender, EventArgs e)
        {
            //get data
            string
                 email = regLogControl1.txbx_email.Text,
                 password = regLogControl1.txbx_password.Text;

            
            using (DatabaseManager db = new DatabaseManager("myDB"))
            {
                users = (List<User>)db.GetUsers();
            }

            if (users.Any(u => u.Email == email))
            {
                User user = new User {Email = email, Password = password, UserType = UserType.User };
                using (DatabaseManager db = new DatabaseManager("myDB"))
                {
                    db.AddUser(user);
                }
                MessageBox.Show("You successfully registered!");
            }
            else
            {
                MessageBox.Show("This user is already exists!");
            }
        }

        private void btn_login_clicked(object sender, EventArgs e)
        {
            List<User> users = null;
            //get data
            string
              email = regLogControl2.txbx_email.Text,
              password = regLogControl2.txbx_password.Text;
            //    //validate data
            //    //check data - database
            User currentUser = users.FindItem(user => user.Email == email && user.Password == password);
            if (currentUser != null)
            {
                Session.User = currentUser;
                Session.LogForm = this;
                if (currentUser.UserType == UserType.User)
                {
                    new MainForm().Show();
                    Hide();
                }

                else if (currentUser.UserType == UserType.Admin)
                {
                    new MainForm().Show();
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Your email or password is wrong!");
            }
        }

       //go to new form or XXX
    }

}

