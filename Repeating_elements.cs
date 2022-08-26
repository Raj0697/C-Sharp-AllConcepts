using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarantine_concepts
{
    class Repeating_elements
    {
        
        static void Main(String[] args)
        {
            int[] ar = { 40, 2, 40, 5, 8, 2, 5, 5 };
            int temp;
            for(int i=0; i<ar.Length-1; i++)
            {
                for(int j=0; j<ar.Length-i-1; j++)
                {
                    if(ar[j] > ar[j + 1])
                    {
                        temp = ar[j];
                        ar[j] = ar[j + 1];
                        ar[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("bubble sort for the given number of array");
            for (int i = 0; i < ar.Length; i++)
                Console.WriteLine(ar[i]);

            int[] arr = {3,4,2,3,16,3,15,16,15,15,16,2,3 };
            
            
            Console.WriteLine("These are the following array elements ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] +" ");
            Console.WriteLine("\n\nlets see the top most repeated elements in the above elements");
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        Console.Write(arr[i] +" ");
                }
            }

            Console.ReadKey();
        }
    }
}
