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
            string password = "1345698746";
            string confirmPass = "1345698746";
            string birthDay = "15";
            string birthYear = "1985";


            //fill ion web form by ID
            webBrowser1.Document.GetElementById("FirstName").SetAttribute("value", firstName);
            webBrowser1.Document.GetElementById("LastName").SetAttribute("value", lastName);
            webBrowser1.Document.GetElementById("GmailAddress").SetAttribute("value", userName);
            webBrowser1.Document.GetElementById("Passwd").SetAttribute("value", password);
            webBrowser1.Document.GetElementById("PasswdAgain").SetAttribute("value", confirmPass);
            //webBrowser1.Document.GetElementById("BirthMonth").SetAttribute("value", "Febuary");
            webBrowser1.Document.GetElementById("BirthDay").SetAttribute("value", birthDay);
            webBrowser1.Document.GetElementById("BirthYear").SetAttribute("value", birthYear);
           
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
           
            webBrowser1.Navigate("https://accounts.google.com/SignUp?service=mail&amp;continue=https%3A%2F%2Fmail.google.com%2Fmail%2F&amp;ltmpl=default");
        }

        private void btn_MS_Live_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate("https://signup.live.com/?wa=wsignin1.0&rpsnv=13&ct=1488906812&rver=6.7.6636.0&wp=MBI_SSL&wreply=https%3a%2f%2faccount.microsoft.com%2fauth%2fcomplete-signin%3fru%3dhttps%253a%252f%252faccount.microsoft.com%252f%253frefd%253daccount.microsoft.com&id=292666&lw=1&fl=easi2&contextid=F34CA29B7FB8DE6C&bk=1488906814&uiflavor=web&uaid=0c93963462344789b3ae291c44de66e1&mkt=EN-US&lc=1033&lic=1");
        }
    }
}
