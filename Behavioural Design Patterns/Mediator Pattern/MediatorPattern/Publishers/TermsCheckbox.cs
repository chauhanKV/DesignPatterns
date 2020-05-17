using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.UIControls
{
    class TermsCheckbox : UIControls
    {
        private bool isChecked;

        public bool IsChecked() { return isChecked; }

        public void setIsChecked(bool value)
        {
            isChecked = value;
            notifyObservers();
        }
    }
}
