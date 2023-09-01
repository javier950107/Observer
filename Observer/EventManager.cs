using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class EventManager
    {
        private Dictionary<string, object> events = new Dictionary<string, object>();

        public void subscribe(string eventType, object listener)
        {
            events.Add(eventType, listener);
        }

        public void unsubscribe(string eventType) 
        {
            events.Remove(eventType);       
        }

        public void notify(string eventType, object data)
        {
            foreach (KeyValuePair<string, object> value in events)
            {
                if(value.Key == eventType)
                {
                    events[value.Key] = data;
                }
            }
        }

        public void getDictionary()
        {
            foreach(KeyValuePair<string, object> value in events)
            {
                Console.WriteLine("Key " + value.Key);
                Console.WriteLine("Value " + events[value.Key]);
            }
        }
    }
}
