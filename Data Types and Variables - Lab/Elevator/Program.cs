using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOfPerson = double.Parse(Console.ReadLine());
            double capacityOfElevator = double.Parse(Console.ReadLine());
            double courses = numberOfPerson / capacityOfElevator;
            Console.WriteLine($"{Math.Ceiling(courses)}");
        }
    }
}
