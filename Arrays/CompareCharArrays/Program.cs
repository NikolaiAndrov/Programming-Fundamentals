using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse).ToArray();
            char[] arr2 = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse).ToArray();

            var minLenght = Math.Min(arr.Length, arr2.Length);
           
            for (int i = 0; i < minLenght; i++)
            {
                if (arr[i] > arr2[i])
                {
                    Console.WriteLine(string.Join("", arr2));
                    Console.WriteLine(string.Join("", arr));
                    break;
                }
                else if (arr2[i] > arr[i])
                {
                    Console.WriteLine(string.Join("", arr));
                    Console.WriteLine(string.Join("", arr2));
                    break;
                }
                else
                {
                    if (minLenght == arr2.Length && i == minLenght -1)
                    {
                        Console.WriteLine(string.Join("", arr2));
                        Console.WriteLine(string.Join("", arr));
                    }
                    else if (minLenght == arr.Length && i == minLenght - 1)
                    {
                        Console.WriteLine(string.Join("", arr));
                        Console.WriteLine(string.Join("", arr2));
                    }
                    else
                    {
                        continue;
                    }
                }
            }
           
        }
    }
}
