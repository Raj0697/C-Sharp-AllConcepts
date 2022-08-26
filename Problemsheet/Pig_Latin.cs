using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                      // sololearn problem
                      // it is the secret language from english
                      // piglatin is the same words in the same order except that you take the first letterof each word and put it on the end
                      // then you add 'ay' to end of that
namespace Quarantine_concepts
{
    class Pig_Latin
    {
        static void Main(String[] args)
        {
            try
            {
                Console.WriteLine("Enter the word : ");
                string str = Console.ReadLine();
                string temp = "", v="",t="";
                string[] s = str.Split(' ');
                for (int i = 0; i < s.Length; i++)
                {
                  //  Console.WriteLine(s[i]);
                    temp += s[i]+" ";
                }
                foreach(string ss in s)
                {
                    v += ss.Substring(0, 1);
                    string sr = ss.Substring(1, ss.Length - 1);
                    string latin = "ay";
                    string st = sr + v + latin;
                    Console.Write(st +" ");
                    v = v.Substring(0, v.Length - 1);
                }
             //   Console.WriteLine(temp);
             //   t += temp.Substring(0, 1);
             //   temp = temp.Substring(1, temp.Length);

                v += str.Substring(0,1);
                str = str.Substring(1, str.Length - 1);
                
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
