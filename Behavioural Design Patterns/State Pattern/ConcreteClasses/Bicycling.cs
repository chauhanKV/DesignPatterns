using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Pattern.ConcreteClasses
{
    class Bicycling : TravelMode
    {
        public void getDirection()
        {
            Console.WriteLine("Bicycling : Getting directions");
            //Console.ReadLine();
        }

        public void getETA()
        {
            Console.WriteLine("Bicycling : Getting ETA");
            //Console.ReadLine();
        }
    }
}
