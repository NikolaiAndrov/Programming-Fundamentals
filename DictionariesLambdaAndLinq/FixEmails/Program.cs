using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> emailList = new Dictionary<string, string>();

            while (true)
            {
                var name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }

                var email = Console.ReadLine();
                var domain = email.Substring(email.Length - 2);

                if (domain == "uk" || domain == "us")
                {
                    continue;
                }
                else
                {
                    emailList.Add(name, email);
                }
            }

            foreach (var item in emailList)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
