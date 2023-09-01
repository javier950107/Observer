using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Application
    {
        public static void Main(string[] args)
        {
            Editor editor = new Editor();
            editor._events.subscribe("open", new LogginListener("c:/open.txt"));
            editor._events.subscribe("save", new EmailAlertListener("admin", "message"));

            editor.openFile();
            editor.saveFile();

            editor._events.getDictionary();
           
        }
    }
}
