using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double waterPr = 0.70 * quantity;
            double coffeePr = 1.00 * quantity;
            double beerPr = 1.70 * quantity;
            double teaPr = 1.20 * quantity;

            switch (profession)
            {
                case "Athlete":

                    Console.WriteLine($"The Athlete has to pay {waterPr:F2}.");
                    break;
                case "Businessman":
                    Console.WriteLine($"The Businessman has to pay {coffeePr:F2}.");
                    break;
                case "Businesswoman":
                    Console.WriteLine($"The Businesswoman has to pay {coffeePr:F2}.");
                    break;
                case "SoftUni Student":
                    Console.WriteLine($"The SoftUni Student has to pay {beerPr:F2}.");
                    break;
                default:
                    Console.WriteLine($"The {profession} has to pay {teaPr:F2}.");
                    break;

            }
        }
    }
}
