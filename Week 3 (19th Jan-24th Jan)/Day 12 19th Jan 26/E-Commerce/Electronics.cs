using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce
{
    internal class Electronics: Product
    {
        public override void AddProduct()
        {
            Category = "Electronics";
            base.AddProduct();
        }
    }
}
