using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.UIControls
{
    class SignUpButton : UIControls
    {
        private bool enable;

        public bool IsEnabled() { return enable;}

        public void setIsEnabled(bool value)
        {
            enable = value;
            notifyObservers();
        }
    }
}
