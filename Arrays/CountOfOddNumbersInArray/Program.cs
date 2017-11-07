using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfOddNumbersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (Math.Abs(numbers[i]) % 2 != 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
