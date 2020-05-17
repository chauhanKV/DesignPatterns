using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class ChatWindow : Window
    {
        protected override void onClosing()
        {
            Console.WriteLine("Doing things before closing");
        }
    }
}
