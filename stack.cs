using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quarantine_concepts
{
    class stack
    {
        static void Main(String[] args)
        {
            Stack<int> s = new Stack<int>();
            Stack<string> st = new Stack<string>();
            st.Push("raj");
            st.Push("vijay");
            st.Push("karthick");
            st.Push("goldberg");
            st.Pop();
            s.Push(1); // insert the element one by one
            s.Push(2);
            s.Push(3);
      //      s.Pop();  removes the element from the last index
            s.Peek();   // points to the highest element in the stack
          //  s.Pop();
            foreach (int i in s)
                Console.Write(i);
            foreach (string t in st)
                Console.WriteLine(t);
            Console.WriteLine(s.Peek());

            var a = 2;
            var b = "1";
            var c = 0;
            var d = int.Parse(a + b + c) / 21;
            Console.WriteLine(d);

            int x = Math.Max(2, -5);
            int y = Math.Min(3, -7);
            int z = Math.Abs(x * y);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.ReadKey();
        }
    }
}
