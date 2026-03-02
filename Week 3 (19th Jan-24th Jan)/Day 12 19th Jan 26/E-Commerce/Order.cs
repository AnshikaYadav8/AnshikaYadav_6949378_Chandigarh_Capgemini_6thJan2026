using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce
{
    internal class Order
    {
        public void PlaceOrder(Cart cart)
        {
            Console.WriteLine("Order placed");
            Console.WriteLine("Total Amount: " + cart.GetTotal());
        }
    }
}
