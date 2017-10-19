using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign_of_Integer_Number
{
    class SignOfIntegerNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintSign(number);
        }

        public static void PrintSign(int n)
        {

            if (n > 0)
            {
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n == 0)
            {
                Console.WriteLine($"The number {n} is zero.");
            }
            else
            {
                Console.WriteLine($"The number {n} is negative.");
            }

        }
    }
}
