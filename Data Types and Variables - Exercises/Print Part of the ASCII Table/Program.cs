using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startDigit = int.Parse(Console.ReadLine());
            int endDigit = int.Parse(Console.ReadLine());

            for (int i = startDigit; i <= endDigit; i++)
            {
                Console.Write((char)i + " ");
            }
       
        }
    }
}
