using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatorPattern.UIControls;

namespace MediatorPattern.Subscriber
{
    class SignUpDialogBox : Observer
    {
        UsernameTextBox userTxtBox = new UsernameTextBox();
        PasswordTextBox pwdTxtBox = new PasswordTextBox();
        TermsCheckbox termschkbox = new TermsCheckbox();
        SignUpButton signUpBtn = new SignUpButton();

        public SignUpDialogBox()
        {
            userTxtBox.attach(this);
            pwdTxtBox.attach(this);
            termschkbox.attach(this);
        }

        private void controlChanged()
        {
            signUpBtn.setIsEnabled(isFormValid());
        }

        private bool isFormValid()
        {
            return (userTxtBox.getUserName() != null && pwdTxtBox.getPassword() != null && termschkbox.IsChecked());
        }

        public void simulateUserInteraction()
        {
            Console.WriteLine("(Initially button should be disabled): " + "SignUp Button Status "+signUpBtn.IsEnabled());

            userTxtBox.setUserName("Miranda");
            Console.WriteLine("(Setting Username: "+userTxtBox.getUserName()+") " + "SignUp Button Status " + signUpBtn.IsEnabled());

            pwdTxtBox.setPassword("password");
            Console.WriteLine("(Setting Password: " + pwdTxtBox.getPassword() + ") " + "SignUp Button Status " + signUpBtn.IsEnabled());

            termschkbox.setIsChecked(true);
            Console.WriteLine("(Setting TermCheckbox: " + termschkbox.IsChecked() + ") " + "SignUp Button Status " + signUpBtn.IsEnabled());
        }

        public void update()
        {
            controlChanged();
        }
    }
}
