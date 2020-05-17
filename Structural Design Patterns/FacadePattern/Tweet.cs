using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Tweet
    {
       private string message;

        public Tweet(string message)
        {
            this.Message = message;
        }

        public string Message { get => message; set => message = value; }
    }
}
