using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern.ConcreteClasses
{
    class Driving : TravelMode
    {
        public void getDirection()
        {
            Console.WriteLine("Driving : Getting directions");
            //Console.ReadLine();
        }

        public void getETA()
        {
            Console.WriteLine("Driving : Getting ETA");
            //Console.ReadLine();
        }
    }
}
