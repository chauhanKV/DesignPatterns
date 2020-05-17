using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern.ConcreteClasses
{
    class Walking : TravelMode
    {
        public void getDirection()
        {
            Console.WriteLine("Walking : Getting directions");
            Console.ReadLine();
        }

        public void getETA()
        {
            Console.WriteLine("Walking : Getting ETA");
            Console.ReadLine();
        }
    }
}
