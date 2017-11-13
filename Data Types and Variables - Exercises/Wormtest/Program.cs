using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            var lengthInMetters = int.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());

            var lengthInCentimeters = lengthInMetters * 100;
            var result = 0.0;

            if (lengthInCentimeters % width == 0 || width == 0)
            {
                result = lengthInCentimeters * width;
                Console.WriteLine($"{result:F2}");

            }
            else 
            {
                result = (lengthInCentimeters / width) * 100;
                Console.WriteLine($"{result:F2}%");
            }
            
        }
    }
}
