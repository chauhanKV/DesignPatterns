using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfResponsibility.Formats;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {

            Excel excel = new Excel(null);
            Number number = new Number(excel);
            JPEG jpeg = new JPEG(number);
            QuickBook quickBook = new QuickBook(jpeg);

            AccountingTool acc = new AccountingTool(quickBook);
            acc.startFormatting();
            Console.ReadLine();
        }
    }
}
