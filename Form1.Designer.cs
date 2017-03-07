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
            this.btn_MS_Live = new System.Windows.Forms.Button();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // txb_firstName
            // 
            this.txb_firstName.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            this.txb_firstName.Location = new System.Drawing.Point(12, 13);
            this.txb_firstName.Name = "txb_firstName";
            this.txb_firstName.Size = new System.Drawing.Size(100, 20);
            this.txb_firstName.TabIndex = 0;
            this.txb_firstName.Text = "FirstName";
            // 
            // txb_lastName
            // 
            this.txb_lastName.Location = new System.Drawing.Point(139, 13);
            this.txb_lastName.Name = "txb_lastName";
            this.txb_lastName.Size = new System.Drawing.Size(100, 20);
            this.txb_lastName.TabIndex = 1;
            this.txb_lastName.Text = "LastName";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 117);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(556, 334);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(78, 65);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 3;
            this.btn_Submit.Text = "Gmail";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // txb_userName
            // 
            this.txb_userName.Location = new System.Drawing.Point(12, 39);
            this.txb_userName.Name = "txb_userName";
            this.txb_userName.Size = new System.Drawing.Size(227, 20);
            this.txb_userName.TabIndex = 4;
            this.txb_userName.Text = "@Gmail.com";
            this.txb_userName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_MS_Live
            // 
            this.btn_MS_Live.Location = new System.Drawing.Point(695, 64);
            this.btn_MS_Live.Name = "btn_MS_Live";
            this.btn_MS_Live.Size = new System.Drawing.Size(75, 23);
            this.btn_MS_Live.TabIndex = 5;
            this.btn_MS_Live.Text = "MS Live";
            this.btn_MS_Live.UseVisualStyleBackColor = true;
            this.btn_MS_Live.Click += new System.EventHandler(this.btn_MS_Live_Click);
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(574, 117);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(549, 334);
            this.webBrowser2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1124, 479);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.btn_MS_Live);
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
        private System.Windows.Forms.Button btn_MS_Live;
        private System.Windows.Forms.WebBrowser webBrowser2;
    }
}

