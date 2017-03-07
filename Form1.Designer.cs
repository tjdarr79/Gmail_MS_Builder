namespace Gmail_MS_builder
{
    partial class Form1
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
            this.txb_firstName = new System.Windows.Forms.TextBox();
            this.txb_lastName = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.txb_userName = new System.Windows.Forms.TextBox();
            this.txb_password = new System.Windows.Forms.TextBox();
            this.txb_confirmPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txb_firstName
            // 
            this.txb_firstName.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            this.txb_firstName.Location = new System.Drawing.Point(22, 278);
            this.txb_firstName.Name = "txb_firstName";
            this.txb_firstName.Size = new System.Drawing.Size(100, 20);
            this.txb_firstName.TabIndex = 0;
            this.txb_firstName.Text = "FirstName";
            // 
            // txb_lastName
            // 
            this.txb_lastName.Location = new System.Drawing.Point(149, 278);
            this.txb_lastName.Name = "txb_lastName";
            this.txb_lastName.Size = new System.Drawing.Size(100, 20);
            this.txb_lastName.TabIndex = 1;
            this.txb_lastName.Text = "LastName";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(22, 12);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1090, 250);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(439, 427);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 3;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // txb_userName
            // 
            this.txb_userName.Location = new System.Drawing.Point(22, 304);
            this.txb_userName.Name = "txb_userName";
            this.txb_userName.Size = new System.Drawing.Size(227, 20);
            this.txb_userName.TabIndex = 4;
            this.txb_userName.Text = "@Gmail.com";
            this.txb_userName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txb_password
            // 
            this.txb_password.Location = new System.Drawing.Point(22, 330);
            this.txb_password.Name = "txb_password";
            this.txb_password.Size = new System.Drawing.Size(227, 20);
            this.txb_password.TabIndex = 5;
            this.txb_password.Text = "Password";
            // 
            // txb_confirmPass
            // 
            this.txb_confirmPass.Location = new System.Drawing.Point(22, 357);
            this.txb_confirmPass.Name = "txb_confirmPass";
            this.txb_confirmPass.Size = new System.Drawing.Size(227, 20);
            this.txb_confirmPass.TabIndex = 6;
            this.txb_confirmPass.Text = "Confirm Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 479);
            this.Controls.Add(this.txb_confirmPass);
            this.Controls.Add(this.txb_password);
            this.Controls.Add(this.txb_userName);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.txb_lastName);
            this.Controls.Add(this.txb_firstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_firstName;
        private System.Windows.Forms.TextBox txb_lastName;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox txb_userName;
        private System.Windows.Forms.TextBox txb_password;
        private System.Windows.Forms.TextBox txb_confirmPass;
    }
}

