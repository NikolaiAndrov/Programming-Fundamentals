using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Even_Or_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            PrintNumbers(numbers, true);
        }

        public static void PrintNumbers(int n, bool isEven)
        {

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0 && isEven)
                {
                    Console.WriteLine("Even: " + i);
                }
                else if (i % 2 == 1 && !isEven)
                {
                    Console.WriteLine("Odd: " + i);
                }
            }
        }
    }
}
