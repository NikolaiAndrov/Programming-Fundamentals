using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magic_letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char notContainLetter = char.Parse(Console.ReadLine());


            for (char i = firstLetter; i <= secondLetter; i++)
            {
                
                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                      string  word = "" + i + j + k;
                        if (!word.Contains(notContainLetter))
                        {
                            Console.Write(word + " ");
                        }
                    }

                }

            }
        }
    }
}
