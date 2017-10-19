using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMinMaxAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }


          var sum = numbers.Sum();
          var min = numbers.Min();
          var max = numbers.Max();
          var average = numbers.Average();
         
         
          Console.WriteLine("Sum = {0}", sum);
          Console.WriteLine("Min = {0}", min);
          Console.WriteLine("Max = {0}", max);
          Console.WriteLine("Average = {0}", average);
        }
    }
}
