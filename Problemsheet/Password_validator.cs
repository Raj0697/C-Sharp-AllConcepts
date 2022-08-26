using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Quarantine_concepts
{
    class Password_validator
    {
        static void Main(String[] args)
        {
            Console.WriteLine("---------password validator----------\n\n\n");
            Console.WriteLine("Enter the password");
            string p = Console.ReadLine();
            Regex num = new Regex("[0-9]");
            var special = new Regex("^[a-zA-Z0-9 ]*$");
            
            int len = p.Length,temp=0,symbol=0;
            for(int i=0; i< len; i++)
            {
                if (char.IsDigit(p[i]))
                    temp++;
            }
            for(int i=0; i< len; i++)
            {
                if (!char.IsLetterOrDigit(p[i]))
                    symbol++;
            }
            Console.WriteLine("Your password contains " + temp +" numbers");
            Console.WriteLine("Your password contains " + symbol +" special characters");
            if(len >= 7 && temp >=2 && symbol >=2)
            {
                Console.WriteLine("Strong");
            }
            Console.ReadKey();
        }
    }
}
