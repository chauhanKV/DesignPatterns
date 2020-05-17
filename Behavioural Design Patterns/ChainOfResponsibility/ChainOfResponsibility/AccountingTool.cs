using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class AccountingTool
    {
        private Handler handler;

        public AccountingTool(Handler handler)
        {
            this.handler = handler;
        }

        public void startFormatting()
        {
            handler.Handle();
        }
    }
}
