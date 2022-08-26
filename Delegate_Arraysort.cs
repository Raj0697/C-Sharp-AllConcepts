using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarantine_concepts
{
    class Delegate_Arraysort
    {
        public delegate void bubblesort(int[] ar);

        public void sort(int[] a)
        {
            int temp;
            for(int i=0; i<a.Length-1; i++)
            {
                for(int j=0; j<a.Length-i-1; j++)
                {
                    if(a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            for(int i=0; i<a.Length; i++)
            {
                Console.Write(a[i] +" ");
            }

        }
        static void Main(String[] args)
        {
            Delegate_Arraysort del = new Delegate_Arraysort();
            bubblesort b = new bubblesort(del.sort);
            int[] a = {9,3,1,5,7,6};
            b(a);
            Console.ReadKey();
        }
    }
}
