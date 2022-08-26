using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarantine_concepts
{
    class Dictionary
    {
        static void Main(String[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(0, "zero");
            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");
            dict.Add(4, "four");
            foreach (var v in dict.Keys)
            {
                Console.WriteLine(v + " : " + dict[v]);
            }
            
            Console.WriteLine("count {0} ", dict.Count);
            Console.WriteLine("\n\n\n\t\t-------------------------HASHSET------------------------\n\n\n");
            HashSet<int> hs = new HashSet<int>();
            HashSet<int> hs2 = new HashSet<int>();
            hs.Add(5);
            
            hs2.Add(15);
            hs2.Add(20);
            foreach(int i in hs)
            {
                Console.WriteLine(i + " ");
            }

            Console.WriteLine(hs.Count);
            Console.Write("\n{15,20} is a subset of {5,10,15,20} : " + hs2.IsSubsetOf(hs));
            Console.ReadKey();
        }
    }
}
