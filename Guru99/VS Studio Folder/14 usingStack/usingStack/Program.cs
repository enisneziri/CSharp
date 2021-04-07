using System;
using System.Collections;

namespace usingStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);

            foreach (Object obj in st)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("The number of elements in the stack " + st.Count);
            Console.WriteLine("Does the stack contain the elements 3 " + st.Contains(3));
        }
    }
}
