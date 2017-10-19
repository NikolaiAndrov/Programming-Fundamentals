using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintFibonacciNumbers(n);
        }

        public static void PrintFibonacciNumbers(int number)
        {
            int num1 = 0;
            int num2 = 1;
            int sum = 0;

            for (int i = 0; i < number; i++)
            {
                sum = num1 + num2; 
                num1 = num2; 
                num2 = sum; 
            }
            Console.WriteLine(Math.Abs(num2));
        }
    }
}
