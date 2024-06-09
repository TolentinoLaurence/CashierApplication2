using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashierApplication2
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user_name;
            string user_password;

            user_name = txtUsername.Text;
            user_password = txtPassword.Text;
            if (user_name == "Cashier101" && user_password == "Password123")
            {
                MessageBox.Show("Successfully Log In");
                frmPurchaseDiscountedItem frmPurchaseDiscountedItem = new frmPurchaseDiscountedItem();
                frmPurchaseDiscountedItem.Show();
                this.Hide();
            }
            else if (user_name == "" || user_password == "")
            {
                MessageBox.Show("Please insert your username and password.");
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
