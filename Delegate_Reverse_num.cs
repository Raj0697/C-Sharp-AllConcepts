using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarantine_concepts
{
    class Delegate_Reverse_num
    {
        public delegate void reverse(int n);
        int remainder,temp=0;
        public void rev(int n)
        {
            while(n != 0)
            {
                remainder = n % 10;
                temp = (temp * 10) + remainder;
                n /= 10;
            }
            Console.WriteLine("The reversed number is {0} ", temp);
        }
        static void Main(String[] args)
        {
            Delegate_Reverse_num del = new Delegate_Reverse_num();
            reverse rv = new reverse(del.rev);
            Console.WriteLine("Enter the number to reverse : ");
            int num = int.Parse(Console.ReadLine());
            rv(num);
            Console.ReadKey();
        }
    }
}
