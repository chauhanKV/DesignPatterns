using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern.ConcreteClasses
{
    class Transit : TravelMode
    {
        public void getDirection()
        {
            Console.WriteLine("Transit : Getting directions");
            Console.ReadLine();
        }

        public void getETA()
        {
            Console.WriteLine("Transit : Getting ETA");
            Console.ReadLine();
        }
    }
}
