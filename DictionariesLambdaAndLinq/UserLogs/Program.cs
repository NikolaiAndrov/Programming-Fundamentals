using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                string[] commandArgs = line.Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);
                var ip = commandArgs[0].Replace("IP=", "");
                var name = commandArgs[2].Replace("user=", "");

                if (!users.ContainsKey(name))
                {
                    users.Add(name, new Dictionary<string, int>());
                }
                if (!users[name].ContainsKey(ip))
                {
                    users[name].Add(ip, 0);
                }
                users[name][ip] += 1;
            }

            foreach (var user in users.OrderBy(x => x.Key))
            {
                Console.WriteLine(user.Key + ": ");

                StringBuilder sb = new StringBuilder();

                foreach (var ipAndCount in user.Value)
                {
                    sb.Append(ipAndCount.Key).Append(" => ")
                        .Append(ipAndCount.Value + ", ");
                }

                sb.Remove(sb.Length - 2, 2);
                sb.Append(".");
                Console.WriteLine(sb.ToString());
            }
        }
    }
}
