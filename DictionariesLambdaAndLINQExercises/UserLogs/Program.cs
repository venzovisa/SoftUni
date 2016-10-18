using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserLogs
{
    public class Program
    {
        public static void Main()
        {
            SortedDictionary<String, Dictionary<String, int>> users = new SortedDictionary<String, Dictionary<String, int>>();
            String command = Console.ReadLine();
            char[] delimiter = { ' ', '='};
            String[] line;
            String ip = "";          
            String user = "";
            while (command != "end")
            {                                    
                  line = command.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                  ip = line[1];
                  user = line[5];
                  if (!users.ContainsKey(user))
                  {
                      Dictionary<String, int> ipCount = new Dictionary<String, int>();
                      ipCount.Add(ip, 1);
                      users.Add(user, ipCount);
                  }
                  else { // increments value of existing ip or add new entry
                      if (users[user].ContainsKey(ip))
                          users[user][ip]++;
                      else users[user].Add(ip, 1);
                  }
                  command = Console.ReadLine();
            };

            // print user and ip
            foreach (var u in users) // users
            {
                Console.WriteLine(u.Key + ":"); // user
                for (int i = 0; i < u.Value.Count; i++ )
                {
                    Console.Write(u.Value.ElementAt(i).Key + " => " + u.Value.ElementAt(i).Value); // ip + count 
                    Console.Write(i == u.Value.Count - 1? "." : ", ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
