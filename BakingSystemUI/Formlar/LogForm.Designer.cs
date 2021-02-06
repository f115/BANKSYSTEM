namespace BakingSystemUI.Forms
{
    partial class LogForm
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
            this.grbx_reg = new System.Windows.Forms.GroupBox();
            this.grbx_log = new System.Windows.Forms.GroupBox();
            this.regLogControl1 = new BakingSystemUI.Controls.RegLogControl();
            this.regLogControl2 = new BakingSystemUI.Controls.RegLogControl();
            this.grbx_reg.SuspendLayout();
            this.grbx_log.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbx_reg
            // 
            this.grbx_reg.Controls.Add(this.regLogControl1);
            this.grbx_reg.Location = new System.Drawing.Point(28, 12);
            this.grbx_reg.Name = "grbx_reg";
            this.grbx_reg.Size = new System.Drawing.Size(226, 223);
            this.grbx_reg.TabIndex = 0;
            this.grbx_reg.TabStop = false;
            this.grbx_reg.Text = "Register";
            // 
            // grbx_log
            // 
            this.grbx_log.Controls.Add(this.regLogControl2);
            this.grbx_log.Location = new System.Drawing.Point(313, 12);
            this.grbx_log.Name = "grbx_log";
            this.grbx_log.Size = new System.Drawing.Size(226, 223);
            this.grbx_log.TabIndex = 1;
            this.grbx_log.TabStop = false;
            this.grbx_log.Text = "Login";
            // 
            // regLogControl1
            // 
            this.regLogControl1.Location = new System.Drawing.Point(21, 46);
            this.regLogControl1.Name = "regLogControl1";
            this.regLogControl1.Size = new System.Drawing.Size(179, 140);
            this.regLogControl1.TabIndex = 0;
            // 
            // regLogControl2
            // 
            this.regLogControl2.Location = new System.Drawing.Point(21, 46);
            this.regLogControl2.Name = "regLogControl2";
            this.regLogControl2.Size = new System.Drawing.Size(179, 140);
            this.regLogControl2.TabIndex = 0;
            // 
            // LogForm
            // 
            this.ClientSize = new System.Drawing.Size(571, 254);
            this.Controls.Add(this.grbx_log);
            this.Controls.Add(this.grbx_reg);
            this.Name = "LogForm";
            this.grbx_reg.ResumeLayout(false);
            this.grbx_log.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbx_regisrter;
        private System.Windows.Forms.TextBox txbx_registerPassword;
        private System.Windows.Forms.Label lbl_registerPassword;
        private System.Windows.Forms.TextBox txbx_registerEmail;
        private System.Windows.Forms.Label lbl_registerEmail;
        private System.Windows.Forms.Button btn_registerSubmit;
        private System.Windows.Forms.GroupBox grbx_login;
        private System.Windows.Forms.TextBox txbx_loginPassword;
        private System.Windows.Forms.Label lbl_loginPassword;
        private System.Windows.Forms.TextBox txbx_loginEmail;
        private System.Windows.Forms.Label lbl_loginEmail;
        private System.Windows.Forms.Button btn_loginSubmit;
        private System.Windows.Forms.GroupBox grbx_reg;
        private Controls.RegLogControl regLogControl1;
        private System.Windows.Forms.GroupBox grbx_log;
        private Controls.RegLogControl regLogControl2;
    }
}