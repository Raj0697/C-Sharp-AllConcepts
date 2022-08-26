using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarantine_concepts
{
    class Anonymous_greatest_number
    {
        public delegate void greatest(int a, int b);
        static void Main(String[] args)
        {
            greatest g = delegate (int a, int b)
            {
                if (a > b)
                {
                    Console.WriteLine("The greatest of two number is {0} ",a);
                }
                else
                {
                    Console.WriteLine("The greatest of two number is {0} ",b);
                }
                
            };
            Console.WriteLine("Enter the value of a :");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of b :");
            int y = int.Parse(Console.ReadLine());

            g(x, y);
            Console.ReadKey();
        }
    }
}
