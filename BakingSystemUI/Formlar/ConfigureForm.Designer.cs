using System;
namespace BakingSystemUI.Forms
{
    partial class ConfigureForm
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
            this.grbx_userInfo = new System.Windows.Forms.GroupBox();
            this.credentialsControl = new BakingSystemUI.Controls.RegLogControl();
            this.txbx_age = new System.Windows.Forms.TextBox();
            this.lbl_age = new System.Windows.Forms.Label();
            this.txbx_surname = new System.Windows.Forms.TextBox();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.txbx_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbx_userInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_userInfo
            // 
            this.grbx_userInfo.Controls.Add(this.credentialsControl);
            this.grbx_userInfo.Controls.Add(this.txbx_age);
            this.grbx_userInfo.Controls.Add(this.lbl_age);
            this.grbx_userInfo.Controls.Add(this.txbx_surname);
            this.grbx_userInfo.Controls.Add(this.lbl_surname);
            this.grbx_userInfo.Controls.Add(this.txbx_name);
            this.grbx_userInfo.Controls.Add(this.lbl_name);
            this.grbx_userInfo.Location = new System.Drawing.Point(32, 51);
            this.grbx_userInfo.Name = "grbx_userInfo";
            this.grbx_userInfo.Size = new System.Drawing.Size(200, 365);
            this.grbx_userInfo.TabIndex = 0;
            this.grbx_userInfo.TabStop = false;
            this.grbx_userInfo.Text = "UserInfo";
            // 
            // credentialsControl
            // 
            this.credentialsControl.Location = new System.Drawing.Point(6, 214);
            this.credentialsControl.Name = "credentialsControl";
            this.credentialsControl.Size = new System.Drawing.Size(180, 145);
            this.credentialsControl.TabIndex = 12;
            this.credentialsControl.Load += new System.EventHandler(this.credentialsControl_Load);
            // 
            // txbx_age
            // 
            this.txbx_age.Location = new System.Drawing.Point(6, 177);
            this.txbx_age.Multiline = true;
            this.txbx_age.Name = "txbx_age";
            this.txbx_age.Size = new System.Drawing.Size(165, 22);
            this.txbx_age.TabIndex = 11;
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Location = new System.Drawing.Point(3, 151);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(26, 13);
            this.lbl_age.TabIndex = 10;
            this.lbl_age.Text = "Age";
            // 
            // txbx_surname
            // 
            this.txbx_surname.Location = new System.Drawing.Point(6, 115);
            this.txbx_surname.Multiline = true;
            this.txbx_surname.Name = "txbx_surname";
            this.txbx_surname.Size = new System.Drawing.Size(165, 22);
            this.txbx_surname.TabIndex = 9;
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(3, 90);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(49, 13);
            this.lbl_surname.TabIndex = 8;
            this.lbl_surname.Text = "Surname";
            // 
            // txbx_name
            // 
            this.txbx_name.Location = new System.Drawing.Point(6, 54);
            this.txbx_name.Multiline = true;
            this.txbx_name.Name = "txbx_name";
            this.txbx_name.Size = new System.Drawing.Size(165, 22);
            this.txbx_name.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(3, 26);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Here you can configure your personal information";
            // 
            // ConfigureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 428);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbx_userInfo);
            this.Name = "ConfigureForm";
            this.Text = "ConfigureForm";
            this.Load += new System.EventHandler(this.ConfigureForm_Load);
            this.grbx_userInfo.ResumeLayout(false);
            this.grbx_userInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_userInfo;
        private System.Windows.Forms.TextBox txbx_age;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.TextBox txbx_surname;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.TextBox txbx_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label1;
        private Controls.RegLogControl credentialsControl;
    }
}