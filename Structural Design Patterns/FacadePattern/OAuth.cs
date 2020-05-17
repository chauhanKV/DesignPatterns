using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class OAuth
    {
        public string requestToken(string appKey, string appSecret)
        {
            Console.WriteLine("Get a request token");
            return "requestToken";
        }

        public string getAccessToken(string requestToken)
        {
            Console.WriteLine("Get an access token");
            return "accessToken";
        }
    }
}
