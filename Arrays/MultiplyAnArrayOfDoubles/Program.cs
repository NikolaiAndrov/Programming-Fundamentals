using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyAnArrayOfDoubles
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().
                Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            var multiplier = double.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] * multiplier + " ");
            }
        }
    }
}
