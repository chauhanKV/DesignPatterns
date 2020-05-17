using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    abstract class Handler
    {
        private Handler next;

        public Handler(Handler next)
        {
            this.next = next;
        }

        public void Handle()
        {
            if (doHandle())
                return;

            if (next != null)
                next.Handle();
        }

        public abstract bool doHandle();
    }
}
