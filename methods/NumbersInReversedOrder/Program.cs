using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            PrintNumbersInReversedOrder(n);
        }

        public static void PrintNumbersInReversedOrder(decimal number)
        {
            string numberStr = number.ToString();

            for (int i = numberStr.Length-1; i >= 0; i--)
            {
                Console.Write(numberStr[i]);
            }
            Console.WriteLine();
        }
    }
}
