using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarantine_concepts
{
    class Queue
    {
        enum Animal
        {
            dog = 2, cat , Horse , mouse
        };
        static void Main(String[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(1);  // inserts the element in the queue
            q.Enqueue(9);
            q.Enqueue(65);
            q.Enqueue(18);
            Console.Write(q.Dequeue()); // removes the top most element
            Console.WriteLine(q.Count() + " " + q.Peek());  // counts the no.of elements in the queue

            Animal a = Animal.Horse;
            Console.WriteLine((int)a);
            Console.ReadKey();
        }
    }
}
