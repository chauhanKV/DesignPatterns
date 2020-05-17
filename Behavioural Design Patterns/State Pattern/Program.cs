using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using State_Pattern.ConcreteClasses;
using State_Pattern.Context;

namespace State_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Map mapobj = new Map();
            mapobj.Mode = new Bicycling();
            mapobj.getDirection();
            mapobj.getETA();
            //Console.ReadLine();


            mapobj.Mode = new Driving();
            mapobj.getDirection();
            mapobj.getETA();
            Console.ReadLine();
        }
    }
}
