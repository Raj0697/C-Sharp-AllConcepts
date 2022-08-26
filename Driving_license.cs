using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarantine_concepts
{
    public class Driving_license
    {
        static void Main(String[] args)
        {
            int t = 0;
            string temp = "";
            Console.WriteLine("Enter the user name");
            string user = Console.ReadLine();
            Console.WriteLine("Enter the available agents : ");
            int agent = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the other names : ");
            string four = Console.ReadLine();
            temp += four + " " + user;

            string[] lines = temp.Split(' ');
            Console.WriteLine("The sorted list of names : ");
            for (int i = 0; i < lines.Length; i++)
            {
                Array.Sort(lines);
                Console.WriteLine("\n" + lines[i]);
                // t += lines[i].IndexOf(user);
            }
            int index = Array.FindIndex(lines,row=>row.Contains(user));
            Console.WriteLine(index);
            if(index == 0)
            {
                t += 20;
            }
            if(index == 1 && agent == 1)
            {
                t += 40;
            }
            if(index == 4 && agent == 1)
            {
                t += 100;
            }
            if(index == 2 && agent == 1)
            {
                t += 60;
            }
            if(index == 3 && agent == 1)
            {
                t += 80;
            }
            if((index == 0 && agent == 2) || (index == 1 && agent == 2))
            {
                t += 20;
            }
            if ((index == 2 && agent == 2) || (index == 3 && agent == 2))
            {
                t += 40;
            }
            if(index == 4 && agent == 2)
            {
                t += 60;
            }
            if((index == 1 && agent == 3) || (index == 2 && agent == 3))
            {
                t += 20;
            }
            if((index == 3 && agent == 3) || (index == 4 && agent == 3))
            {
                t += 40;
            }
            if((index == 1 && agent == 4) || (index == 2 && agent == 4) || (index == 3 && agent == 4))
            {
                t += 20;
            }
            if(index == 4 && agent == 4)
            {
                t += 40;
            }
            
            Console.WriteLine(t);
            /*
            var dict = new Dictionary<string, int>();
            dict.Add(temp, 1);
            var list = dict.Keys.ToList();
            list.Sort();
            foreach(var k in list)
            {
                Console.WriteLine("{0}:{1} ", k, dict[k]);
            }
            */
            Console.ReadKey();
        }
    }
}
