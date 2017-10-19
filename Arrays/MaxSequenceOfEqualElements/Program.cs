using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int count = 1;
            int maxCount = 0;
            var result = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        result = numbers[i];
                    }
                }
                else
                {
                    count = 1;
                }
            }

            if (maxCount == 0)
            {
                Console.WriteLine(count);
            }
            else
            {
                for (int i = 0; i < maxCount; i++)
                {
                    Console.Write(result + " ");
                   
                }
            }
        }
    }
}
