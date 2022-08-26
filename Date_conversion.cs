using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Quarantine_concepts
{
    class Date_conversion
    {
        static void Main(String[] args)
        {
           //     Console.WriteLine("Enter the date in U.S format(MM/DD/YYYY) : ");
             //   string d = Console.ReadLine();
              //  DateTime dt = DateTime.Parse(d);
             //   dt.ToString("dd/MM/yyyy");
              //  String.Format("dd/MM/yyyy", dt);
             //   Console.WriteLine("The converted date is : " + dt);
                
                
                Console.WriteLine("Enter the United States date format(mm/dd/yyyy) : ");
                string date = Console.ReadLine();
                DateTime dt = Convert.ToDateTime(date);
                Console.WriteLine(dt.Day + "/" + dt.Month + "/" + dt.Year);
            Console.ReadKey();

        }
    }
}
