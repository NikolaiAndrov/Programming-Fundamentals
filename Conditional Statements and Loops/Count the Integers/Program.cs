﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            while (true)
            {
                try
                {
                    int n = int.Parse(Console.ReadLine());
                    count++;
                }
                catch (Exception)
                {
                    Console.WriteLine(count);
                    return;
                    
                }

            }
        }
    }
}
