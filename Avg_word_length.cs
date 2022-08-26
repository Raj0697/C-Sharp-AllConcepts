using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
                                    // sololearn problem
namespace Quarantine_concepts
{
    class Avg_word_length
    {
        static void Main(String[] args)
        {
            double temp = 0, avg;
            Console.WriteLine("Enter the word");
            string str = Console.ReadLine();
            double len = str.Length;
            for(int i=0; i<len; i++)
            {
                if (char.IsWhiteSpace(str[i]))
                    temp++;
            }
        //  string r = Regex.Replace(str, "[ ]", "a");
            Console.WriteLine("total whitespaces found in string is " + temp);
            len -= temp;
            avg = len / (temp + 1);
            Console.WriteLine("Total words are : " + (temp+1));
            Console.WriteLine("Total length of words excluding whitespaces are : " + len);
            Console.WriteLine("The average of the string is " + avg);
            Console.WriteLine("The rounding upto the nearest whole number results in : " + Math.Ceiling(avg));
            Console.ReadKey();
        }
    }
}
