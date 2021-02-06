using BakingSystemUI.Core;
using BakingSystemUI.Data;
using BakingSystemUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakingSystemUI.Forms
{
    public partial class ConfigureForm : Form
    {
        public ConfigureForm()
        {
            InitializeComponent();
        }

        private void btn_updateUser(object sender, EventArgs e)
        {
            int aRows = UpdateUser(Session.User);
            if (aRows < 0)
            MessageBox.Show("User updeted!");
            else
                MessageBox.Show("Udeted failed!");
        }
        private void ConfigureForm_Load(object sender, EventArgs e)
        {
            GetCurrentUser(Session.User);
        }

        private void GetCurrentUser(User user)
        {
            txbx_age.Text = user.Age.ToString();
            txbx_name.Text = user.Name;
            txbx_surname.Text = user.Surname;
            credentialsControl.txbx_email.Text = user.Email;
            credentialsControl.txbx_password.Text = user.Password;
        }

        private void UpdateUser(User user)
        {
            int affectedRows = 0;
            user.Name = txbx_name.Text;
            user.Surname = txbx_surname.Text;
            user.Age = byte.Parse(txbx_age.Text);
            user.Password = credentialsControl.txbx_password.Text;
            user.Email = credentialsControl.txbx_email.Text;

            using (DatabaseManager db = new DatabaseManager("myDB"))
            {
                affectedRows = db.UpdateUser(user);
            }
            return affectedRows;
        }

        private void grbx_user_Enter(object sender, EventArgs e)
        {

        }

        private void credentialsControl_Load(object sender, EventArgs e)
        {

        }
    }
}
