using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    class ProductCollection
    {
        private List<Product> products = new List<Product>();
        // private List<Product> products = new ArrayList<Product>(); ? why I can't do this?

        public void addProducts(string productName)
        {
            products.Add(new Product(productName));
        }

        public List<Product> getProducts()
        {
            return products;
        }

        public Iterator<Product> createIterator()
        {
            return new ListIterator(this);
        }

        private class ListIterator : Iterator<Product>
        {
            private ProductCollection product;
            private int index;
            public ListIterator(ProductCollection product)
            {
                this.product = product;
            }
            public Product current()
            {
                return product.products[index]; 
            }

            public bool hasNext()
            {
                return (index < product.getProducts().Count());
            }

            public void next()
            {
                index++;
            }
        }


    }
}
