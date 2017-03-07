using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gmail_MS_builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //webBrowser1.Navigate("https://accounts.google.com/SignUp?service=mail&amp;continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&amp;ltmpl=default");
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string firstName = txb_firstName.Text;
            string lastName = txb_lastName.Text;
            string userName = txb_userName.Text;
            string password = txb_password.Text;
            string confirmPass = txb_confirmPass.Text;

            //fill ion web form by ID
            webBrowser1.Document.GetElementById("FirstName").SetAttribute("value", firstName);
            webBrowser1.Document.GetElementById("LastName").SetAttribute("value", lastName);
            webBrowser1.Document.GetElementById("GmailAddress").SetAttribute("value", userName);
            webBrowser1.Document.GetElementById("Passwd").SetAttribute("value", password);
            webBrowser1.Document.GetElementById("PasswdAgain").SetAttribute("value", confirmPass);

           
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
           
            webBrowser1.Navigate("https://accounts.google.com/SignUp?service=mail&amp;continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&amp;ltmpl=default");
        }
    }
}
