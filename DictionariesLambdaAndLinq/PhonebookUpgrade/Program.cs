using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new SortedDictionary<string, string>();
           

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "END")
                {
                    break; 
                }

                var commandArgs = input.Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);

                if (commandArgs[0] == "A")
                {
                    phonebook[commandArgs[1]] = commandArgs[2];
                }
                else if (commandArgs[0] == "S")
                {
                    if (!phonebook.ContainsKey(commandArgs[1]))
                    {
                        Console.WriteLine($"Contact {commandArgs[1]} does not exist.");
                    }
                    else
                    {
                        foreach (var item in phonebook)
                        {
                            if (item.Key == commandArgs[1])
                            {
                                Console.WriteLine($"{item.Key} -> {item.Value}");
                            }
                        }
                    }
                }
                else if (commandArgs[0] == "ListAll")
                {
                    foreach (var item in phonebook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }
            }
        }
    }
}
