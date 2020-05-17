using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.ConcreteClasses;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatClient obj = new ChatClient();
            string message = "Encrypt me!";
            obj.encryptMessage(message, new AES());
            obj.encryptMessage(message, new DES());

            Console.ReadLine();
        }
    }
}
