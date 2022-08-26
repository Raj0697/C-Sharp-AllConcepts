using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarantine_concepts
{
    class string_reverse
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the word : ");
            string str = Console.ReadLine();
            string rev = "";
            int len = str.Length - 1;
            while(len >= 0)
            {
                rev += str[len];
                len--;
            }
            // using character array and built-in () called reverse....
            char[] c = str.ToArray();
            Array.Reverse(c);
            Console.WriteLine(c);
            Console.WriteLine("The reversed word is : " + rev);
            Console.ReadKey();
        }
    }
}
