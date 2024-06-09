using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication2
{
    internal class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double paymentRecieve;
        private double change;

        public DiscountedItem(string name, double price, int quantity, double discount)
            : base(name, price, quantity)
        {
            item_discount = discount;
        }

        public override double GetTotalPrice()
        {
            discounted_price = item_price - (item_discount * 0.01 * item_price);
            total_price = discounted_price * item_quantity;
            return total_price;
        }

        public override void SetPayment(double amount)
        {
            paymentRecieve = amount;
        }

        public double GetChange()
        {
            change = paymentRecieve - total_price;
            return change;
        }

    }
}
