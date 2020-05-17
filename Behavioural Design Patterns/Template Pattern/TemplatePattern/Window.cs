using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public class Window
    {

        public void close()
        {
            onClosing();
            Console.Write("Window is closing. Thankyou");
            onClosed();
        }

        protected virtual void onClosing() { }
        protected virtual void onClosed() { }


    }
}
