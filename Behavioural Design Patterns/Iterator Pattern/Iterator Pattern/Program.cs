using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var productCollection = new ProductCollection();
            productCollection.addProducts("Phone");
            productCollection.addProducts("Camera");
            productCollection.addProducts("Headset");


            Iterator<Product> iterator = productCollection.createIterator();


            while (iterator.hasNext())
            {
                Console.WriteLine(iterator.current().ProductName);
                iterator.next();
            }

            Console.ReadLine();


        }
    }
}
