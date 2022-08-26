using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarantine_concepts
{
    public delegate void show(string x);
    public delegate void hide(char v);
    class Anonymous_methods_2
    {
        public static void identity(show pet,string color)
        {
            color = "black" + color;
            pet(color);
        }

        public static void example(hide h,char c)
        {
            c = 'R';
            h(c);
        }
        static void Main(String[] args)
        {
            // anonymous methods
            identity(delegate (string color)
            {
                Console.WriteLine("the color of cat is " + color);
            } , " white");

            example(delegate (char c)
            {
                Console.WriteLine("The character is {0} ", c);
            } ,'h');
            Console.ReadKey();

        }

    }
}
