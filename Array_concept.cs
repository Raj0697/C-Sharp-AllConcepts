using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarantine_concepts
{
    class Array_concept
    {
        static void Main(String[] args)
        {
            int[] ar = {40,2,40,5,8,2,5,5 };
            var dict = new Dictionary<int, int>();

            foreach(var value in ar)
            {
                if (dict.ContainsKey(value))
                    dict[value]++;
                else
                    dict[value] = 1;
            }

            foreach (var pair in dict)
                Console.WriteLine("value {0} --> {1} . ", pair.Key, pair.Value);
            Console.ReadKey();
        }
    }
}
