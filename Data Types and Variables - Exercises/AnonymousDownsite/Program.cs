using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfWebsites = int.Parse(Console.ReadLine());
            var securiryKey = int.Parse(Console.ReadLine());
            var totaMoneyLoss = 0.0m;

            for (int i = 0; i < numberOfWebsites; i++)
            {
                var inputLine = Console.ReadLine().Split();
                var siteName = inputLine[0];
                var siteVisits = decimal.Parse(inputLine[1]);
                var siteCommercialPricePerVisit = decimal.Parse(inputLine[2]);
                var siteLoss = siteVisits * siteCommercialPricePerVisit;
                totaMoneyLoss += siteLoss;

                Console.WriteLine(siteName);
            }

            Console.WriteLine($"Total Loss: {totaMoneyLoss:F20}");
            Console.WriteLine($"Security Token: {BigInteger.Pow(securiryKey, numberOfWebsites)}");
        }
    }
}
