using System;

namespace _13_DeclareingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32[] value;
            value = new Int32[4];

            value[0] = 1;
            value[1] = 2;
            value[2] = 3;
            value[3] = 4;

            Console.WriteLine(value[0]);
            Console.WriteLine(value[1]);
            Console.WriteLine(value[2]);
            Console.WriteLine(value[3]);

        }
    }
}
