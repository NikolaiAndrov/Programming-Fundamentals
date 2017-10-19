using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbersAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            foreach (var number in numbers)
            {
                Console.WriteLine("{0} => {1}", number, Math.Round(number, MidpointRounding.AwayFromZero));
            }
        }
    }
}
