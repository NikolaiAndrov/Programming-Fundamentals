using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                numbers.Add(currentNumber);
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
