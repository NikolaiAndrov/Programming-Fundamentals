using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (c < GetMin(a, b))
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(GetMin(a, b));
            }
 
        }
        
        public static int GetMin(int a, int b)
        {
            return Math.Min(a, b);
        }
    }
}
