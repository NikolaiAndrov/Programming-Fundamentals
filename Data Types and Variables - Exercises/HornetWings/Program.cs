using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            var wingFlaps = long.Parse(Console.ReadLine());
            var distanceWingFlaps = double.Parse(Console.ReadLine());
            var hornetEndurance = long.Parse(Console.ReadLine());

            var distance = (wingFlaps / 1000) * distanceWingFlaps;
            var seconds = wingFlaps / 100;
            var totalSeconds = (wingFlaps / hornetEndurance) * 5 + seconds;

            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{totalSeconds} s.");
        }
    }
}
