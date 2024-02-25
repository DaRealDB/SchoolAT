namespace SchoolAT
{
    partial class LoginFrm
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
            this.mtxb_user = new MetroFramework.Controls.MetroTextBox();
            this.mtxb_pass = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mbtn_login = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // mtxb_user
            // 
            this.mtxb_user.Location = new System.Drawing.Point(30, 193);
            this.mtxb_user.Name = "mtxb_user";
            this.mtxb_user.Size = new System.Drawing.Size(307, 49);
            this.mtxb_user.TabIndex = 0;
            // 
            // mtxb_pass
            // 
            this.mtxb_pass.Location = new System.Drawing.Point(30, 293);
            this.mtxb_pass.Name = "mtxb_pass";
            this.mtxb_pass.PasswordChar = '*';
            this.mtxb_pass.Size = new System.Drawing.Size(307, 49);
            this.mtxb_pass.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(30, 162);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Username";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(28, 271);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Password";
            // 
            // mbtn_login
            // 
            this.mbtn_login.Location = new System.Drawing.Point(128, 362);
            this.mbtn_login.Name = "mbtn_login";
            this.mbtn_login.Size = new System.Drawing.Size(81, 32);
            this.mbtn_login.TabIndex = 4;
            this.mbtn_login.Text = "Login";
            this.mbtn_login.Click += new System.EventHandler(this.mbtn_login_Click);
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(363, 437);
            this.Controls.Add(this.mbtn_login);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mtxb_pass);
            this.Controls.Add(this.mtxb_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox mtxb_user;
        private MetroFramework.Controls.MetroTextBox mtxb_pass;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton mbtn_login;
    }
}