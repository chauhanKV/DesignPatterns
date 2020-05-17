using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            show();
        }
        public static void show()
        {
            var fontStyle = new FontStyle("Calibri", 12, false);
            var sheet = new SpreadSheet(fontStyle);
            sheet.setContent(0, 0, "Hello");
            sheet.setContent(1, 0, "World");
            sheet.setFontFamily(0, 0, "Arial");
            sheet.render();
            Console.ReadLine();
        }
    }
}
