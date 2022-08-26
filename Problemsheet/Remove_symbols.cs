using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Quarantine_concepts
{
    class Remove_symbols
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the string : ");
            string str = Console.ReadLine();
            string s = "",t="";
            char[] c = str.ToCharArray();
            for(int i=0; i<str.Length; i++)
            {
                if (!char.IsLetterOrDigit(str[i]))
                    s += str[i];
            }
            t += Regex.Replace(str, "[^a-zA-Z0-9 ]", "");
            Console.WriteLine(t);
            Console.ReadKey();
        }
    }
}
