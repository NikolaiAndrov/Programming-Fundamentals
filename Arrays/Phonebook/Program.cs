using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            var names = Console.ReadLine()
                .Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            var count = 0;

            while (true)
            {
                var line = Console.ReadLine();
                count++;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (names[i] == line)
                    {
                        Console.WriteLine($"{names[i]} -> {numbers[i]}");
                    }
                }

                if (line.Equals("done"))
                {
                    break;
                }
 
            }
        }
    }
}
