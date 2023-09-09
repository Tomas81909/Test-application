using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form5 : Form
    {
    
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int minLength = 8; //minimun characters
            int maxLength = 12; //macimum characters

            //these character will be used in our random password
            string charAvailable = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            StringBuilder password = new StringBuilder();
            Random rdm = new Random();

            //random lentgh for passowr dis 8 - 12 characters
            int passwordLength = rdm.Next(minLength, maxLength + 1);

            //add a random character to your password intil it reaches the randomized length
            while (passwordLength-- > 0)
                password.Append(charAvailable[rdm.Next(charAvailable.Length)]);

            lblPassword.Text = password.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new Main().Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
