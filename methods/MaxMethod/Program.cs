using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstDigit = long.Parse(Console.ReadLine());
            long secondtDigit = long.Parse(Console.ReadLine());
            long thirdDigit = long.Parse(Console.ReadLine());

            GetMax(firstDigit, secondtDigit, thirdDigit);
        }

        public static long GetMax(long num1, long num2, long num3)
        {
            long bigestNumber = 0;

            if (num1 > num2 && num1 > num3)
            {
                bigestNumber += num1;
                Console.WriteLine(bigestNumber);
            }
            else if (num2 > num1 && num2 > num3)
            {
                bigestNumber += num2;
                Console.WriteLine(bigestNumber);
            }
            else if(num3 > num2 && num3 > num1)
            {
                bigestNumber += num3;
                Console.WriteLine(bigestNumber);
            }
            return bigestNumber;
        }
    }
}
