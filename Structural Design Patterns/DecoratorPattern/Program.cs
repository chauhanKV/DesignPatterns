using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Decorators;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            show();
            Console.ReadLine();
        }

        public static void show()
        {
            var editor = new Editor();
            editor.openProject("...");
        }
    }
}
