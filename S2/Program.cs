﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int N = int.Parse(Console.ReadLine());
            int max = N * 2;
            Console.WriteLine("Multiply the number by 2: " + max);
            Console.ReadKey();
        }
    }
}
