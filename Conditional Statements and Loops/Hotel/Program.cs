using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nightCount = int.Parse(Console.ReadLine());

            double studioPrice = 0.0;
            double doublePrice = 0.0;
            double suitePrice = 0.0;

            if (month == "may" || month == "october")
            {
                studioPrice = 50;
                doublePrice = 65;
                suitePrice = 75;
            }
            else if (month == "june" || month == "september")
            {
                studioPrice = 60;
                doublePrice = 72;
                suitePrice = 82;
            }
            else if ( month == "july" || month == "august" || month == "december")
            {
                studioPrice = 68;
                doublePrice = 77;
                suitePrice = 89;
            }

            if (nightCount > 7 && (month == "may" || month == "october"))
            {
                studioPrice *= 0.95;
            }
            else if (nightCount > 14 && (month == "june" || month == "september"))
            {
                doublePrice *= 0.90;
            }
            else if (nightCount > 14 && (month == "july" || month == "august" ||
                month == "december"))
            {
                suitePrice *= 0.85;
            }

            double totalStudioPr = studioPrice * nightCount;
            double totalDoublePr = doublePrice * nightCount;
            double totalSuitePr = suitePrice * nightCount;
            
            if (nightCount > 7 && (month == "september" || month == "october"))
            {
                totalStudioPr = studioPrice * (nightCount -1);
            }
            Console.WriteLine($"Studio: {totalStudioPr:F2} lv.");
            Console.WriteLine($"Double: {totalDoublePr:F2} lv.");
            Console.WriteLine($"Suite: {totalSuitePr:F2} lv.");
        }
    }
}
