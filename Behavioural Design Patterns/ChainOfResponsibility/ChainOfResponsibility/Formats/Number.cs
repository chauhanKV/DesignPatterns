using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Number : Handler
    {
        private Handler next;
        public Number(Handler next) : base(next)
        {
            this.next = next;
        }

        public override bool doHandle()
        {
            Console.WriteLine("Formatting to Number..");
            return false;
        }
    }
}
