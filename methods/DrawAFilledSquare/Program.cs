using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            DrawSquare(n);
        }

        public static void DrawSquare(int n)
        {
            PrintHeaderRow(n);
            PrintMiddleRow(n);
            PrintSecond MiddleRow(n);
            PrintHeaderRow(n);
        }
        
        public static void PrintHeaderRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        public static void PrintMiddleRow(int n)
        {
            Console.Write("-");
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }

        public static void PrintSecondMiddleRow(int n)
        {
            Console.Write("-");
            for (int i = 1; i < n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }


    }
}
