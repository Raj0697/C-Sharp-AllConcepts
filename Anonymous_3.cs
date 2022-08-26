using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarantine_concepts
{
    public delegate void calc(int a);
    class Anonymous_3
    {
        static int num = 50;
        public static void add(int b)
        {
            Console.WriteLine("addition = " + (b+ num));
        }
        public static void sub(int c)
        {
            Console.WriteLine("subtraction = " + (c - num));
        }
        public static void mul(int d)
        {
            Console.WriteLine("multiplication = " + (d*num));
        }
        static void Main(String[] args)
        {
            // anonymous method
            calc cl = delegate (int n)
            {
                Console.WriteLine("Anonymous method value {0} ", n);
            };
            // calling the delegate using anonymous method
            cl(60);
            // instantiating delegate using named method
            cl = new calc(add);
            // calling the delegate using named methods
            cl(50);
            // instantiating delegate using another named method
            cl = new calc(sub);
            cl(80);
            cl = new calc(mul);
            cl(100);
            Console.ReadKey();
        }
    }
}
