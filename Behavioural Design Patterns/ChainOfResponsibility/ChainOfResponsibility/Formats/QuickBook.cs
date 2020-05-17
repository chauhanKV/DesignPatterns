using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class QuickBook : Handler
    {
        private Handler next;
        public QuickBook(Handler next) : base(next)
        {
            this.next = next;
        }

        public override bool doHandle()
        {
            Console.WriteLine("Formatting to QuickBook..");
            return false;
        }
    }
}
