using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object obj = hello + " " + world;
            string helloWorld = (string)obj;
            Console.WriteLine( helloWorld);
        }
    }
}
