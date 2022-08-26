using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarantine_concepts
{
   public class Boxing
    {
        public static void number(int a,int b)
        {
            a = a * a;
            b = b * b;
            Console.WriteLine("Value of a is {0} ", a);
            Console.WriteLine("Value of b is {0} ", b);
        }
        public double num(double s)
        {
            Console.WriteLine(s);
            return Math.Sqrt(s);
        }
       public static void Main(String[] args)
        {
            //  int n = 50;
            // Object ob = n;
            // n = 100;
            //Console.WriteLine("Value type of n is {0} ", n);
            //Console.WriteLine("Reference type of n is {0} ", ob);
            int a = 5, b = 10;
            float d = a;
            float f = (float)d;
            Console.WriteLine(f + " " + b);
            number(5, 10);
            Boxing bb = new Boxing();
            bb.num(9);
            Console.WriteLine(a + " " + b);
            Console.ReadKey();
        }
    }
}
