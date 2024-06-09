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
    public partial class frmPurchaseDiscountedItem : Form
    {
        private DiscountedItem discountedItem;
        public frmPurchaseDiscountedItem()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.Show();
            this.Hide();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string itemName = txtItemName.Text;
            double itemPrice = Convert.ToDouble(txtPrice.Text);
            int itemQuantity = Convert.ToInt32(txtQuantity.Text);
            double discount = Convert.ToDouble(txtDiscount.Text);

            discountedItem = new DiscountedItem(itemName, itemPrice, itemQuantity, discount);

            double totalPrice = discountedItem.GetTotalPrice();
            lblTotalAmount.Text = totalPrice.ToString("0.00");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (discountedItem != null)
            {
                double paymentAmount = Convert.ToDouble(txtPaymentRecieve.Text);
                discountedItem.SetPayment(paymentAmount);
                double change = discountedItem.GetChange();
                lblChange.Text = change.ToString("0.00");
            }
            else
            {
                MessageBox.Show("Calculate total price first.");
            }
        }
    }
}
