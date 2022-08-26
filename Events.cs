using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarantine_concepts
{
    // publisher class
    class exam
    {
        // delegate creation
        public delegate void example();
        // event creation
        public event example event_delegate;

        public void add(int a, int b)
        {
            if (event_delegate != null)
            {
                event_delegate();
                Console.WriteLine("add result " + (a + b));
            }
            else
            {
                Console.WriteLine("not subscribed to event");
            }
        }
        public void subtract(int a,int b)
        {
            if(event_delegate != null)
            {
                event_delegate();
                Console.WriteLine("subtract result is " + (a - b));
            }
            else
            {
                Console.WriteLine("not subscribed to event");
            }
        }
    }
    // Subscriber class
    class operations
    {
        exam e = new exam();
        public int a, b;
        public operations(int x,int y)
        {
            // subscribe to event delegate by using += operator and unsubscribe by using -=
            e.event_delegate += eventhandler;
            a = x;
            b = y;
        }
        // event handler
        private void eventhandler()
        {
            Console.WriteLine("calling method");
        }
        public void add()
        {
            e.add(a, b);
        }
        public void sub()
        {
            e.subtract(a, b);
        }
    }
    class Events
    {
        static void Main(String[] args)
        {

            Console.WriteLine("--------------Events example---------------\n\n");
            operations op = new operations(50, 10);
            op.add();
            op.sub();
            Console.WriteLine("Press any key to continue !!");
            Console.ReadKey();
        }
    }
}
