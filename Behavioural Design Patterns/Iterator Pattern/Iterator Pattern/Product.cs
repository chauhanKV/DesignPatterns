using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    class Product
    {
        private string productName;

        public Product(string productName)
        {
            this.ProductName = productName;
        }

        public string ProductName { get => productName; set => productName = value; }
    }
}
