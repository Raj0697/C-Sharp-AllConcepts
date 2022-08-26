using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Quarantine_concepts
{
    class No_numbers
    {
        static void Main(String[] args)
        {
            string[] ar = {"0","1","2","3","4","5","6","7","8","9" };
            string[] word = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
          //  str = str.Replace("[^0-9]+", " ");
            string temp = "";

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("0", "zero");
            dict.Add("1", "one");
            dict.Add("2", "two");
            dict.Add("3", "three");
            dict.Add("4", "four");
            dict.Add("5", "five");
            dict.Add("6", "six");
            dict.Add("7", "seven");
            dict.Add("8", "eight");
            dict.Add("9", "nine");
            
      //      foreach (string d in dict.Keys)
        //        Console.WriteLine(d + " : " + dict[d]);
       //     Console.WriteLine("dictionary count : {0} ", dict.Count);

            for (int i=0; i<str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                    temp += str[i];
            }
            Console.WriteLine(temp);
            string rep = Regex.Replace(str, "[0-9]{2,}", "*");
                       /*
            switch (temp)
            {
                case "0":
                    Console.WriteLine("zero");
                    break;
                case "1":
                    Console.Write("one");
                    break;
                case "2":
                    Console.Write("two");
                    break;
                case "3":
                    Console.Write("three");
                    break;
            }
            */
            //  Console.WriteLine(temp);
            if (str.Contains("0"))
            {
                string re = Regex.Replace(str, "[0]", "zero");
                Console.WriteLine(re);
            }
            if (str.Contains("1"))
            {
                Console.WriteLine(Regex.Replace(str, "[1]", "one"));
            }
            if (str.Contains("2"))
            {
                Console.WriteLine(Regex.Replace(str, "[2]", "two"));
            }
            if (str.Contains("3"))
            {
                Console.WriteLine(Regex.Replace(str, "[3]", "three"));
            }
            if (str.Contains("4"))
            {
                Console.WriteLine(Regex.Replace(str, "[4]", "four"));
            }
            if (str.Contains("5"))
            {
                Console.WriteLine(Regex.Replace(str, "[5]", "five"));
            }
            if (str.Contains("6"))
            {
                Console.WriteLine(Regex.Replace(str, "[6]", "six"));
            }
            if (str.Contains("7"))
            {
                Console.WriteLine(Regex.Replace(str, "[7]", "seven"));
            }
            if (str.Contains("8"))
            {
                Console.WriteLine(Regex.Replace(str, "[8]", "eight"));
            }
            if (str.Contains("9"))
            {
                Console.WriteLine(Regex.Replace(str, "[9]", "nine"));
            }

            //    Console.WriteLine(rep);

            /*
            //       string st = Regex.Match(str, @"\d+").Value;
            //       Console.WriteLine(st);
            Regex re = new Regex(@"\d+");
            Match m = re.Match(str);
            if (m.Success)
            {
                temp += m.Value;
                m = m.NextMatch();
                Console.WriteLine(temp);              
                //  Console.WriteLine(String.Format("Regex found" + m.Value + "at position " + m.Index.ToString()));
            }
            else
            {
                Console.WriteLine("you didn't enter string containing number");
            }
            */
            Console.ReadKey();
        }
    }
}
