using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Strategy;

namespace StrategyPattern.ConcreteClasses
{
    class DES : Encryption
    {
        private string message;
        public void encrypt(string message)
        {

            Console.WriteLine("Encrypting " + message + " to DES");
        }
    }
}
