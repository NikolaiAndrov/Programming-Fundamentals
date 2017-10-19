using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSorted
{
    class Program
    {
        static void Main()
        {
            var words = Console.ReadLine()
                 .ToLower()
                 .Split(new char[] { '.',  ',',  ':',  ';',  '(',  ')',   '[',   ']',   '\\',
                 '\"',   '\'',   '/',   '!',   '?',  ' ' })
                 .ToList();
                 

            var result = words
                .Distinct()
                .OrderBy(x => x)
               .Where(w => w.Length < 5)
               .ToList();

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
