using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Editor
    {
        public EventManager _events;
        public Editor() 
        {
            this._events = new EventManager();
        }


        public void openFile()
        {
            this._events.notify("open", "Archivo.txt");
        }

        public void saveFile()
        {
            this._events.notify("save", "Guardar info en archivo.txt");
        }
    }
}
