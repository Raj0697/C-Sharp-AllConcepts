using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarantine_concepts
{
    public class Security
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter");
            string str = Console.ReadLine();
            
            string t = "";
          //  t += str.Replace('x', ' ');
            string[] s = str.Split('x');
            Console.WriteLine(t);
            int gaurd = Array.FindIndex(s, row => row.Contains("G"));
            int money = Array.FindIndex(s, r => r.Contains("$"));
            int thief = Array.FindIndex(s, x => x.Contains("T"));
            Console.WriteLine(gaurd);
            Console.WriteLine(money);
            Console.WriteLine(thief);
            if(gaurd < money)
            {
                Console.WriteLine("ALARM");
            }
            else
            {
                Console.WriteLine("quiet");
            }
            Console.ReadKey();
        }
    }
}
