using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarantine_concepts
{
    public delegate string dele(string str);
    
    class Events_delegate
    {
        // event declaration
        public event dele eventdele;

        public Events_delegate()
        {
            this.eventdele += new dele(this.user);
        }
        public string user(string uname)
        {
            return "welcome " + uname;
        }
        static void Main(String[] args)
        {
            int x = 5;
            double f = x;
            int v = (int)f;

            Events_delegate edele = new Events_delegate();
            Console.WriteLine(edele.eventdele("rajkumar"));
            Console.ReadKey();
        }
    }
}
