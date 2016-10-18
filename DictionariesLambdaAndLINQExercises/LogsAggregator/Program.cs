using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogsAggregator
{
    public class User { 
        public string name;
        public Dictionary<String, int> session = new Dictionary<String, int>();
        public ulong totalDuration;
    }
   public class Program
    {
        public static void Main(string[] args)
        {
            List<User> users = new List<User>();
            int n = int.Parse(Console.ReadLine());           
            for (int i = 0; i < n; i++)
            {
                User newUser = new User();
                String command = Console.ReadLine();
                String[] input = command.Split();
                String ip = input[0];
                String name = input[1];
                int duration = int.Parse(input[2]);
                bool hasUser = false;
                int userIndex = 0;

                for (int u = 0; u < users.Count; u++)
                {
                    if (name == users[u].name) { hasUser = true; userIndex = u; break; }
                }

                // add user
                if (!hasUser) {
                    newUser.name = name;
                    newUser.session.Add(ip, duration);
                    users.Add(newUser);
                } else {
                // add ip to existent user

                    if (!users[userIndex].session.ContainsKey(ip))
                    { users[userIndex].session.Add(ip, duration); }
                    else { users[userIndex].session[ip] += duration; }
                }
            }
            // sum total duration
            for (int d = 0; d < users.Count; d++)
            {
                ulong totalDuration = 0;
                for (int x = 0; x < users[d].session.Count; x++)
                {
                    totalDuration += (ulong)users[d].session.ElementAt(x).Value;
                }
                users[d].totalDuration = totalDuration;
            }

            // sort users
            users = users
                .OrderBy(a => a.name)                
                .ToList();

            // sort ips
            for (int i = 0; i < users.Count; i++)
            {
                users[i].session = users[i].session
                    .OrderBy(a => a.Key)
                    .ToDictionary(a => a.Key, a => a.Value);
            }

            // print user and ip
            for (int u = 0; u < users.Count; u++) // users
            {
                Console.Write("{0}: {1} [", users[u].name, users[u].totalDuration);
                for (int x = 0; x < users[u].session.Count; x++) // ip
                {
                    Console.Write(users[u].session.ElementAt(x).Key); // ip + count 
                    Console.Write(x == users[u].session.Count - 1 ? "" : ", ");
                }
                Console.Write("]");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}