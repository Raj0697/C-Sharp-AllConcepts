using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarantine_concepts
{
    class Anonymous_Methods
    {
        public delegate void names(string x);
        static void Main(String[] args)
        {
   /* outer variable*/  string d = "sunny";
            // anonymous methods
            names n = delegate (string s)
            {
                Console.WriteLine(s + " " + d);
            };
            //inner var
            n("raj");
            Console.ReadKey();
        }
    }
}
