﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int times = 0;

            for (int i = 1; i <= 10; i++)
            {
                times = n * i;
                Console.WriteLine($"{n} X {i} = {times}");
            }
        }
    }
}
