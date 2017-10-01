using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centuries_to_Minuties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Centuries = ");
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            Console.WriteLine($"{centuries} = {years} years = {days} days = " +
                $"{hours} hourse = {minutes} minutes");
        }
    }
}
