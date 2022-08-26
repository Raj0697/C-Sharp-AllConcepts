using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Quarantine_concepts
{
    class Spy_Life
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the string : ");
            string str = Console.ReadLine();
            string s = "";
            s += Regex.Replace(str, "[^a-zA-Z ]", "");
            char[] c = s.ToArray();
            Array.Reverse(c);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
