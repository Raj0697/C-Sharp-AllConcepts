using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarantine_concepts
{
    public delegate void name();
    class master
    {
        public string n;
        public master(string str)
        {
            n = str;
        }
        public void eventhandler()
        {
            Console.WriteLine("Notification from {0} ", n);
        }
    }
    class events_example
    {
        public static event name evt;
        public static void sendnotification()
        {
            if(evt != null)
            {
                evt();
                Console.WriteLine("subscribed to event");
            }
            else
            {
                Console.WriteLine("not subscribed to event");
            }
        }
        static void Main(String[] args)
        {
            master m1 = new master("Name is raj");
            evt += new name(m1.eventhandler);
            sendnotification();
            Console.ReadKey();
        }
    }
}
