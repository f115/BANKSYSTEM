namespace BakingSystemUI.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbx_cards = new System.Windows.Forms.GroupBox();
            this.lnLbl_orderCards = new System.Windows.Forms.LinkLabel();
            this.lnLbl_myCards = new System.Windows.Forms.LinkLabel();
            this.grbx_user = new System.Windows.Forms.GroupBox();
            this.lbl_age = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.grbx_setting = new System.Windows.Forms.GroupBox();
            this.lnLbl_settings = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.link_refresh = new System.Windows.Forms.LinkLabel();
            this.grbx_cards.SuspendLayout();
            this.grbx_user.SuspendLayout();
            this.grbx_setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_cards
            // 
            this.grbx_cards.Controls.Add(this.lnLbl_orderCards);
            this.grbx_cards.Controls.Add(this.lnLbl_myCards);
            this.grbx_cards.Location = new System.Drawing.Point(12, 177);
            this.grbx_cards.Name = "grbx_cards";
            this.grbx_cards.Size = new System.Drawing.Size(200, 100);
            this.grbx_cards.TabIndex = 3;
            this.grbx_cards.TabStop = false;
            this.grbx_cards.Text = "Cards";
            // 
            // lnLbl_orderCards
            // 
            this.lnLbl_orderCards.AutoSize = true;
            this.lnLbl_orderCards.Location = new System.Drawing.Point(9, 68);
            this.lnLbl_orderCards.Name = "lnLbl_orderCards";
            this.lnLbl_orderCards.Size = new System.Drawing.Size(62, 13);
            this.lnLbl_orderCards.TabIndex = 1;
            this.lnLbl_orderCards.TabStop = true;
            this.lnLbl_orderCards.Text = "Order cards";
            this.lnLbl_orderCards.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnLbl_orderCards_LinkClicked);
            // 
            // lnLbl_myCards
            // 
            this.lnLbl_myCards.AutoSize = true;
            this.lnLbl_myCards.Location = new System.Drawing.Point(9, 31);
            this.lnLbl_myCards.Name = "lnLbl_myCards";
            this.lnLbl_myCards.Size = new System.Drawing.Size(50, 13);
            this.lnLbl_myCards.TabIndex = 0;
            this.lnLbl_myCards.TabStop = true;
            this.lnLbl_myCards.Text = "My cards";
            this.lnLbl_myCards.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnLbl_myCards_LinkClicked);
            // 
            // grbx_user
            // 
            this.grbx_user.Controls.Add(this.lbl_age);
            this.grbx_user.Controls.Add(this.lbl_surname);
            this.grbx_user.Controls.Add(this.lbl_name);
            this.grbx_user.Location = new System.Drawing.Point(12, 12);
            this.grbx_user.Name = "grbx_user";
            this.grbx_user.Size = new System.Drawing.Size(187, 113);
            this.grbx_user.TabIndex = 2;
            this.grbx_user.TabStop = false;
            this.grbx_user.Text = "User";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(6, 84);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(32, 13);
            this.lbl_age.TabIndex = 3;
            this.lbl_age.Text = "Age: ";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(6, 55);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(55, 13);
            this.lbl_surname.TabIndex = 2;
            this.lbl_surname.Text = "Surname: ";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(6, 26);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(41, 13);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name: ";
            // 
            // grbx_setting
            // 
            this.grbx_setting.Controls.Add(this.lnLbl_settings);
            this.grbx_setting.Location = new System.Drawing.Point(262, 125);
            this.grbx_setting.Name = "grbx_setting";
            this.grbx_setting.Size = new System.Drawing.Size(200, 68);
            this.grbx_setting.TabIndex = 4;
            this.grbx_setting.TabStop = false;
            this.grbx_setting.Text = "Settings";
            // 
            // lnLbl_settings
            // 
            this.lnLbl_settings.AutoSize = true;
            this.lnLbl_settings.Location = new System.Drawing.Point(18, 31);
            this.lnLbl_settings.Name = "lnLbl_settings";
            this.lnLbl_settings.Size = new System.Drawing.Size(45, 13);
            this.lnLbl_settings.TabIndex = 5;
            this.lnLbl_settings.TabStop = true;
            this.lnLbl_settings.Text = "Settings";
            this.lnLbl_settings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnLbl_settings_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(441, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(42, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "LogOut";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // link_refresh
            // 
            this.link_refresh.AutoSize = true;
            this.link_refresh.Location = new System.Drawing.Point(441, 38);
            this.link_refresh.Name = "link_refresh";
            this.link_refresh.Size = new System.Drawing.Size(44, 13);
            this.link_refresh.TabIndex = 6;
            this.link_refresh.TabStop = true;
            this.link_refresh.Text = "Refresh";
            this.link_refresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_refresh_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 306);
            this.Controls.Add(this.link_refresh);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.grbx_setting);
            this.Controls.Add(this.grbx_cards);
            this.Controls.Add(this.grbx_user);
            this.Name = "MainForm";
            this.Text = "UserForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grbx_cards.ResumeLayout(false);
            this.grbx_cards.PerformLayout();
            this.grbx_user.ResumeLayout(false);
            this.grbx_user.PerformLayout();
            this.grbx_setting.ResumeLayout(false);
            this.grbx_setting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_cards;
        private System.Windows.Forms.LinkLabel lnLbl_orderCards;
        private System.Windows.Forms.LinkLabel lnLbl_myCards;
        private System.Windows.Forms.GroupBox grbx_user;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.GroupBox grbx_setting;
        private System.Windows.Forms.LinkLabel lnLbl_settings;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel link_refresh;
    }
}