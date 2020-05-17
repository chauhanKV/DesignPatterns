using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.UIControls
{
    class UsernameTextBox : UIControls
    {
        private string username;

        public string getUserName()
        {
            return this.username;
        }

        public void setUserName(string username)
        {
            this.username = username;
            notifyObservers();
        }
    }
}
