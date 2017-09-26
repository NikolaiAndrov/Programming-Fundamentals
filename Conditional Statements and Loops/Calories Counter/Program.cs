using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int cheese = 500;
            int tomatoSauce = 150;
            int salami = 600;
            int pepper = 50;
            int total = 0;

            for (int i = 1; i <= n; i++)
            {
                string ingradients = Console.ReadLine().ToLower();
                if (ingradients == "cheese")
                {
                    total += cheese;
                }
                else if (ingradients == "tomato sauce")
                {
                    total += tomatoSauce;
                }
                else if (ingradients == "salami")
                {
                    total += salami;
                }
                else if (ingradients == "pepper")
                {
                    total += pepper;
                }
            }
            Console.WriteLine($"Total calories: {total}");
        }
    }
}
