using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.UIControls
{
    class PasswordTextBox : UIControls
    {
        private string password;

        public string getPassword()
        {
            return this.password;
        }

        public void setPassword(string password)
        {
            this.password = password;
            notifyObservers();
        }
    }
}
