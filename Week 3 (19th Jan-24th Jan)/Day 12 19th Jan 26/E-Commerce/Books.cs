using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce
{
    internal class Books: Product
    {
        public override void AddProduct()
        {
            Category = "Books";
            base.AddProduct();
        }
    }
}
