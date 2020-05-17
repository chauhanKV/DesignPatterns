using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Excel : Handler
    {
        private Handler next;
        public Excel(Handler next) : base(next)
        {
            this.next = next;
        }

        public override bool doHandle()
        {
            Console.WriteLine("Formatting to excel..");
            return false;
        }
    }
}
