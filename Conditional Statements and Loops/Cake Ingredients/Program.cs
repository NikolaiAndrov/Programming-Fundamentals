using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            while (true)
            {
                string ingradients = Console.ReadLine();
                if (ingradients != "Bake!")
                {
                    Console.WriteLine($"Adding ingredient {ingradients}.");
                }
                
                count++;
                if (ingradients == "Bake!")
                {
                    break;
                }
                :
            }
            Console.WriteLine($"Preparing cake with {count -1} ingredients.");

        }
    }
}
