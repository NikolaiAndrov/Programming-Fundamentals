using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            string input = Console.ReadLine();

            while (input != "print")
            {
                var commandArgs = input.Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (commandArgs[0].Equals("add"))
                {
                    numbers.Insert(int.Parse(commandArgs[1]), int.Parse(commandArgs[2]));
                }
                else if (commandArgs[0].Equals("addMany"))
                {
                    numbers.InsertRange(int.Parse(commandArgs[1]), commandArgs.Skip(2)
                        .Select(int.Parse).ToArray());
                }
                else if (commandArgs[0].Equals("contains"))
                {
                    if (numbers.Contains(int.Parse(commandArgs[1])))
                    {
                        Console.WriteLine(numbers.IndexOf(int.Parse(commandArgs[1])));
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
                else if (commandArgs[0].Equals("remove"))
                {
                    numbers.RemoveAt(int.Parse(commandArgs[1]));
                }
                else if (commandArgs[0].Equals("shift"))
                {
                    var number = int.Parse(commandArgs[1]);
                    number = number % numbers.Count;
                    for (int i = 0; i < number; i++)
                    {
                        numbers.Add(numbers[0]);
                        numbers.RemoveAt(0);
                    }

                }
                else if (commandArgs[0].Equals("sumPairs"))
                {
                    for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        var sum = numbers[i] + numbers[i + 1];
                        numbers[i] = sum;
                        numbers.RemoveAt(i + 1);
                    }
                }


                input = Console.ReadLine();
            }

            Console.WriteLine($"[{string.Join(", ", numbers)}]");
        }
    }
}
