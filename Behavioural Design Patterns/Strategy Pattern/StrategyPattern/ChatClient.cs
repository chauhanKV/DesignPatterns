using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Strategy;

namespace StrategyPattern
{
    class ChatClient
    {
        public void encryptMessage(string message, Encryption encryptionType)
        {
           encryptionType.encrypt(message);
        }
    }
}
