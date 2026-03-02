using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce
{
    internal class Clothing: Product
    {
        public override void AddProduct()
        {
            Category = "Clothing";
            base.AddProduct();
        }
    }
}
