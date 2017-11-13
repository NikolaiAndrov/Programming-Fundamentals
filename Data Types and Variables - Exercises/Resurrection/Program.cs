using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            var amountOfPphoenix = int.Parse(Console.ReadLine());

            for (int i = 0; i < amountOfPphoenix; i++)
            {
                var bodyLength = long.Parse(Console.ReadLine());
                var bodyWidth = decimal.Parse(Console.ReadLine());
                var wingLength = long.Parse(Console.ReadLine());

                var totalYears = (bodyLength * bodyLength) * ((bodyWidth) + (2 * wingLength));

                Console.WriteLine($"{totalYears}");
            }
        }
    }
}
