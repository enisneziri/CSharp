﻿using System;

namespace _13_changeNvalue
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 350;
            int v = 0;
            int p = 3;
            n = (v == 0) ? n = n & (~(1 << p)) : n = n | (1 << p);
            Console.WriteLine(n);
        }
    }
}
