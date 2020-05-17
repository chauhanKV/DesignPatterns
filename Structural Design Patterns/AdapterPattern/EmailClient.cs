using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class EmailClient : EmailProvider
    {
        private List<EmailProvider> emailProviders = new List<EmailProvider>();

        public void addProvider(EmailProvider provider)
        {
            emailProviders.Add(provider);
        }

        public void downloadEmails()
        {
            foreach (EmailProvider provider in emailProviders)
                provider.downloadEmails();
        }
    }
}
