using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Truck : Resource
    {
        public void deploy()
        {
            Console.WriteLine("Deploying Truck.");
        }
    }
}
