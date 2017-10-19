using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintName(name);
        }

        public static string PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
            return name;
        }
    }
}
