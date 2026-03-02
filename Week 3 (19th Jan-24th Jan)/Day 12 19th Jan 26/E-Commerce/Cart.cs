using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce
{
    internal class Cart
    {
        public List<Product> products = new List<Product>();

        public void AddToCart(Product p)
        {
            if (p.Stock > 0)
            {
                products.Add(p);
                p.Stock--;
                Console.WriteLine("Product added to cart");
            }
            else
            {
                Console.WriteLine("Out of stock");
            }
        }

        public double GetTotal()
        {
            double total = 0;
            foreach (Product p in products)
            {
                total += p.Price*p.Quantity;
            }
            return total;
        }
    }
}
