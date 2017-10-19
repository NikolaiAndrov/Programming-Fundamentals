using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blank_Receipt
{
    class BlancReceipt
    {
       public static void Main(string[] args)
        {
            PrintReceipt();

        }

        public static void PrintReceipt()
        {
            PrintHeaderOfReceipt();
            PrintBodyOfReceipt();
            PrintFooterOfReceipt();
        }

        public static void PrintHeaderOfReceipt()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        public static void PrintBodyOfReceipt()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        public static void PrintFooterOfReceipt()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }

    }
}
