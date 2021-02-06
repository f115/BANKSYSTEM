using BakingSystemUI.Core;
using System;
using BakingSystemUI.Roles;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BakingSystemUI.Data;

namespace BakingSystemUI.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void lnLbl_cards_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //dataGridView1.DataSource = Session.Data.Cards.GetAll()
            //              .Select(card => new { card.Id, card.CardHolder, card.Bank, card.CardType, card.CardNumber, card.CVC, card.ExpiredDate })
            //              .ToList();
            using (DatabaseManager databaseManager = new DatabaseManager("myDB"))
            {
                dataGridView1.DataSource = databaseManager.GetCards().ToList()
                    .Select(card => new { card.Id, card.CardHolder, card.Bank, card.CardType, card.CardNumber, card.CVC, card.ExpiredDate })
                    .ToList();
            }
        }

        private void lnLbl_users_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //dataGridView1.DataSource = Session.Data.Users.GetAll()
            //    .Select(user => new { user.Id, FullName = $"{user.Name}, {user.Surname}, {user.Age}", user.Email })
            //    .ToList();         
            
            using(DatabaseManager databaseManager = new DatabaseManager("myDB"))
            {
                dataGridView1.DataSource = databaseManager.GetUsers().Where(u => u.UserType == UserType.User).ToList();
            }
        }

        private void lnLbl_refresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminForm_Load(sender, e);
        }

        private void lnLbl_logOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Session.AdminForm = this;
            Session.LogForm.Show();
        }

        private void grbx_stats_Enter(object sender, EventArgs e)
        {

        }
    }
}
