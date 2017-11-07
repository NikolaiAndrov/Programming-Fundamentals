using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToBase
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());
            Console.WriteLine(IntegerToBase(numbers, toBase));
        }

        public static string IntegerToBase(int numbers, int toBase)
        {
            var result = string.Empty;

            while (numbers > 0)
            {
                var reminder = numbers % toBase;
                result = reminder + result;
                numbers /= toBase;
            }

            return result;
        }
    }
}
