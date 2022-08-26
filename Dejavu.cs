using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
                                // sololearn problem => dejavu
                                // it means already seen in general, but now the task is to find the repeated letters in the program
                                // if there is any repeated letters then print => dejavu else "unique"....
namespace Quarantine_concepts
{
    class Dejavu
    {
        public int repeat(string word)
        {
            var c = 0;
            string t = "";
            for(var i=0; i<word.Count()-1; i++)
            {
                if(word[i] == word[i + 1])
                {
                    c++;
                    t += word[i];
                }
            }
          //  Console.WriteLine(t);
            if(c >= 1)
            {
                Console.WriteLine("Deja Vu");
            }
            else
            {
                Console.WriteLine("Unique");
            }
         //   Console.Write(c);
            return c;
        }

        public int repeatedcount(string s,char ch)
        {
            var count = 0;
            for(int i = 0; i < s.Length - 1; i++)
            {
                if(ch == s[i])
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(String[] args)
        {
            Dejavu dj = new Dejavu();
            
            Console.WriteLine("Enter only letters : ");
            string str = Console.ReadLine();
            dj.repeat(str);
        //    Console.WriteLine("Enter to know the repeated characters");
        //    char ch = Convert.ToChar(Console.ReadLine());
        //    int p = dj.repeatedcount(str, ch);
        //    Console.WriteLine(p);
            /*
            string t = "";
            int l = str.Length,count=0;
            for(int i=0; i<l; i++)
            {
                if (!char.IsLetter(str[i]))
                    Console.WriteLine("no numbers and special characters are allowed");
            }
            char[] c = str.ToCharArray();

            for(int i=0; i < c.Length; i++)
            {
                for(int j=i+1; j<=c.Length-1; j++)
                {
                    if(c[i] == c[j])
                    {
                        count+=1;
                        t += c[i];
                    }
                }
            }
          //  Console.WriteLine("The repeated characters are " + t);
            if (count >= 1)
            {
                Console.WriteLine("Deja Vu"); 
            }
            else
            {
                Console.WriteLine("Unique");
            }
            */
            Console.ReadKey();
        }
    }
}
