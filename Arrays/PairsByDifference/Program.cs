using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int difference = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = numbers[i];

                for (int j = 0; j < numbers.Length; j++)
                {
                    var secondCurrentNumber = numbers[j];

                    if (currentNumber - secondCurrentNumber == difference)
                    {
                        count++;
                    }
                   
                }
            }

            Console.WriteLine(count);
        }
    }
}
