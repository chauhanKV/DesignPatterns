﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Formats
{
    class JPEG : Handler
    {
        private Handler next;
        public JPEG(Handler next) : base(next)
        {
            this.next = next;
        }

        public override bool doHandle()
        {
            Console.WriteLine("Formatting to JPEG..");
            return false;
        }
    }
}
