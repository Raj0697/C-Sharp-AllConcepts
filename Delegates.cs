using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarantine_concepts
{
    class Delegates
    {
        public delegate void d1(int x,int y);
        public delegate double d2(double b);
        public double m1(double a)
        {
            return Math.Sqrt(a);
        }
        public void m2(int x1,int y1)
        {
            Console.WriteLine(x1+y1);
            Console.WriteLine(x1 - y1);
        }
        static void Main(String[] args)
        {
            Delegates dele = new Delegates();
            // creating instances for delegates
            d1 del1 = new d1(dele.m2);
            del1(25, 10);
            d2 del2 = new d2(dele.m1);
            del2(81);
            Console.WriteLine(del2(625));
            Console.ReadKey();
        }
    }
}
