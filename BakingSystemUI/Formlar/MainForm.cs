using BakingSystemUI.Core;
using BakingSystemUI.Models;
using System;
using BakingSystemUI.Roles;
using BakingSystemUI.Data;
using BakingSystemUI.Validation;
using BakingSystemUI.Controls;
using System.Windows.Forms;

namespace BakingSystemUI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void lnLbl_settings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ConfigureForm().ShowDialog();
        }

        private void lnLbl_myCards_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new CardsForm().ShowDialog();
        }

        private void lnLbl_orderCards_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new CardManagerForm().ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Session.LogForm.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Session.MainForm = this;
            Session.LogForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            User currentUser = Session.User;
            lbl_name.Text = $"Name: {currentUser.Name}";
            lbl_surname.Text = $"Surname: {currentUser.Surname}";
            lbl_age.Text = "Age: " + currentUser.Age;
        }

        private void link_refresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm_Load(sender, e);
        }
    }
}
