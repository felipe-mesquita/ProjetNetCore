﻿using System;
using Library;

namespace console_app
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************************");
            Console.WriteLine($"The answer is {new Thing().Get(19, 23)}");
            Console.WriteLine("****************************************");
        }
    }
}
