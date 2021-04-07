using System;
using System.Collections;

namespace _17_removingQue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue qt = new Queue();
            qt.Enqueue(1);
            qt.Enqueue(2);
            qt.Enqueue(3);

            qt.Dequeue();

            foreach (Object obj in qt)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
