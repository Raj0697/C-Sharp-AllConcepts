using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   // DATE : 08-04-2020
                                // TIME : 7:54 PM
                                // BOXING AND UNBOXING
namespace Quarantine_concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 34;
            Object ob = a; // boxing
            int x = (int)ob; // unboxing
            a = 50;
            Console.WriteLine(x);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
