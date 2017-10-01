using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());

            if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u' || a == 'y')
            {
                Console.WriteLine("vowel");
            }
            else if (char.IsNumber(a))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
