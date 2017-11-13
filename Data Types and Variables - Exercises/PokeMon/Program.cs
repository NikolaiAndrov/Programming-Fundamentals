using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var count = 0;
            var reminder = 0;
            var percent = n / 2;

            while (n >= m)
            {
                n -= m;
                
                if (n == percent)
                {
                    if (y > 0)
                    {
                        n /= y;
                    }
                }
                count++;
            }

            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}
