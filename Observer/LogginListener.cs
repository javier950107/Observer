using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class LogginListener : EventListener
    {
        private string _message;

        public LogginListener(string message)
        {
            this._message = message;
        }
        public void update(string filename)
        {
            Console.WriteLine("Update the information of file");
        }
    }
}
