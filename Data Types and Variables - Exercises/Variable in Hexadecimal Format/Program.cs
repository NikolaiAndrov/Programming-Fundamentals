using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int a = Convert.ToInt32(str, 16);
            Console.WriteLine(a);

        }
    }
}
