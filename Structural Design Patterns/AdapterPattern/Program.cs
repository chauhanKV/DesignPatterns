using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailClient emailClient = new EmailClient();
            emailClient.addProvider(new GmailClientAdapter(new GmailClient()));
            emailClient.downloadEmails();
            Console.ReadLine();
        }
    }
}
