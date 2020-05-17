using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class GmailClientAdapter : EmailProvider
    {
        private GmailClient gmailClient = new GmailClient();
        public GmailClientAdapter(GmailClient gmailClient)
        {
            this.gmailClient = gmailClient;
        }
        public void downloadEmails()
        {
            gmailClient.connect();
            gmailClient.getEmails();
            gmailClient.disconnect();
        }
    }
}
