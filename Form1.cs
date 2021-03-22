using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {



            string city = txtCity.Text.Trim();
            string state = txtState.Text.Trim();
            string zip = txtZipCode.Text.Trim();

            string email = txtEmail.Text.Trim();
            int userName = email.IndexOf('@')+1;

            if (userName > 0)
            {
                string userEmail = email.Substring(0, userName);
                string emailDomain = email.Substring(userName);

                MessageBox.Show("email: " + userEmail + "\n" + "Domain: " + emailDomain, "Parsed String");
                MessageBox.Show("City: " + city + "\n" + "State: " + state + "\n"+"Zip Code: "+zip);

            }


        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            txtCity.Clear();
            txtEmail.Clear();
            txtState.Clear();
            txtZipCode.Clear();
        }
    }
}
