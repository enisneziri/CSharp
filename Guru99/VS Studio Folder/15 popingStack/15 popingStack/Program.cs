using System;
using System.Collections;

namespace _15_popingStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);

            st.Pop();

            foreach (Object obj in st)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
