using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            int times = 0;
                           
            for (int i = multiplier; i <= 10; i++)
            {
                times = i * n;
                Console.WriteLine($"{n} X {i} = {times}");
            }

            if (multiplier > 10)
            {
                times = n * multiplier;
                Console.WriteLine($"{n} X {multiplier} = {times}");
            }

        }
    }
}
