using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepeater
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            RepeatString(line, count);
        }

        public static void RepeatString(string str, int count)
        {
            string repeatedString = string.Empty;

            for (int i = 0; i < count; i++)
            {
                repeatedString += str;
            }
            Console.WriteLine(repeatedString);
        }
    }
}
