using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorPattern.Subscriber;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SignUpDialogBox signUpForm = new SignUpDialogBox();
            signUpForm.simulateUserInteraction();
            Console.ReadLine();
        }
    }
}
