using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            ChatWindow objChat = new ChatWindow();
            objChat.close();
            Console.ReadLine();
        }
    }
}
