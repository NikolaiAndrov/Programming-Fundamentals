using System;
using System.Linq;

namespace Demo
{
    public class Program
    {
        public static void Main()
        {
            int a = 5;
            int b = 5;
            Console.WriteLine(a + b);
        }

        public static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }
        public static char GetMax(char a, char b)
        {
            return (char)GetMax((int)a, (int)b);
        }
        public static string GetMax(string a, string b)
        {
            if (a.CompareTo(b) < 0)
            {
                return b;
            }
            else
            {
                return a;
            }
        }


        public static string FullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }

        public static int Pow(int initialNimber, int power)
        {
            int result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= initialNimber;
            }
            return result;
        }


        public static bool IsEven(int n)
        {
            return n % 2 == 0;
        }

        public static int MultipleOfNumbers(int a, int b)
        {
             
            return a * b;
        }

        public static void SumOfArrNumbers(params int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }


        public  static void PrintNumbersOfRange(int min, int max)
        {
            if (min > max)
            {
                PrintNumbersOfRange(max, min );
            }

            for (int i = min; i <= max; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintNumbers(int n, bool isEven)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0 && isEven)
                {
                    Console.WriteLine(i);
                }
                else if (i % 2 != 0 && !isEven)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void SumOfN(int n)
        {
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }

        public static void Print(bool header)
        {
            if (header)
            {
                Console.WriteLine("this is header");
            }
            else
            {
                Console.WriteLine("this is bottom");
            }
        }
    }

}
