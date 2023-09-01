using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class EmailAlertListener : EventListener
    {
        private string _email;
        private string _message;

        public EmailAlertListener(string email, string message)
        {
            this._email = email;
            this._message = message;
        }

        public void update(string filename)
        {
            Console.WriteLine("Update Email alert");
        }
    }
}
