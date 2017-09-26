using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine())+ 30;
            
            if (minutes > 59)
            {
                hours++;
                minutes -= 60;
            }
            if (hours > 23)
            {
                hours = 0;
            
            }
            if (minutes < 10)
            {
                Console.WriteLine($"{hours}:{minutes:D2}");
            }
            else
            {
                Console.WriteLine("{0}:{1}", hours, minutes);
            }

        }
    }
}
