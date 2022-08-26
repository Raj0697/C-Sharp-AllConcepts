using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarantine_concepts
{
    class Time_conversion
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the time in 12-hour format : ");
            string time = Console.ReadLine();
            DateTime d = DateTime.Parse(time);
            Console.WriteLine(d.ToString("HH:mm"));
            Console.ReadKey();
        }
    }
}
