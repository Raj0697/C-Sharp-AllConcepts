using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarantine_concepts
{

    class Delegates_2
    {
        public delegate void sum(int x, int y);
        public delegate void sub(int a, int b);
        public delegate string names(string str);
        public delegate double square_root(double sq);

        public void sum1(int x1,int y1)
        {
            Console.WriteLine("Addition of two numbers is {0} ", x1 + y1);
        }
        public void sub1(int x2,int y2)
        {
            Console.WriteLine("Subtraction of two numbers is {0} ", x2 - y2);
        }
        public string name(string str2)
        {
            return str2;
        }
        public double square(double d)
        {
            return Math.Sqrt(d);
        }
        static void Main(String[] args)
        {
            Delegates_2 dele = new Delegates_2();
            sum s = new sum(dele.sum1);
            sub s2 = new sub(dele.sub1);
            names s3 = new names(dele.name);
            square_root s4 = new square_root(dele.square);
            // passing values to methods from delegates instances
            s(10, 20);
            s2(30, 40);
            s3("Rajkumar");
            Console.WriteLine("Enter the number to find the square root");
            double a = double.Parse(Console.ReadLine());
            s4(a);
            Console.WriteLine("The name of the user is {0} ", s3("Rajkumar"));
            Console.WriteLine("Square root of " + a + " is {0} ",s4(a));
            Console.ReadKey();
        }
    }
}
