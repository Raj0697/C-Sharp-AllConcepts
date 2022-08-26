using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
                                    // sololearn problem
namespace Quarantine_concepts
{
    class sum_of_even_numbers
    {
        static void Main(String[] args)
        {
            Console.Write("Enter the no.of elements : ");
            int n = int.Parse(Console.ReadLine());
            int[] ar = new int[n];
            int even = 0,odd = 0;
            Console.WriteLine("Enter " + n + " integers one by one");
            for(int i=0; i<ar.Length; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0; i<ar.Length; i++)
            {
                if(ar[i] % 2 == 0)
                {
                    even += ar[i];
                    Console.WriteLine("The even numbers are {0} " ,ar[i]);
                }
                else
                {
                    odd += ar[i];
                    Console.WriteLine("The odd numbers are {0} ", ar[i]);
                }
            }
            Console.WriteLine("sum of even numbers is " + even);
            Console.WriteLine("sum of odd numbers is " + odd);
            Console.ReadKey();
        }
    }
}
