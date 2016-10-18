using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace MentorGroup
{
    public class User {
       public String name;
       public List<String> comments = new List<String>();
       public List<DateTime> dates = new List<DateTime>();
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            List<User> users = new List<User>(); 
            String command = Console.ReadLine();
            
            String format = "dd/MM/yyyy";
            CultureInfo provider = CultureInfo.CurrentCulture;
            while (command != "end of dates")
            {
                String[] input = command.Split(',', ' ');
                
                int userIndex = 0;

                bool hasUser = false;
                for (int u = 0; u < users.Count; u++)
                {
                    if (users[u].name == input[0]) {
                        userIndex = u;
                        hasUser = true; 
                        break; }
                }

                if (!hasUser)
                {
                    User user = new User();
                        for (int d = 1; d < input.Length; d++)
                        {
                            user.dates.Add(DateTime.ParseExact(input[d], format, provider));
                        }

                    user.name = input[0];
                    users.Add(user);
                } // update user data
                else {
                     // add dates
                        for (int d = 1; d < input.Length; d++)
                        {
                            users[userIndex].dates.Add(DateTime.ParseExact(input[d], format, provider));
                        }                                       
                }                
                command = Console.ReadLine();
            }

            // comments

            while (command != "end of comments")
            {
                String[] input = command.Split('-');               
                int userIndex = 0;

                bool hasUser = false;
                for (int u = 0; u < users.Count; u++)
                {
                    if (users[u].name == input[0])
                    {
                        userIndex = u;
                        hasUser = true;
                        break;
                    }
                }

                if (!hasUser)
                { // add comment  
                    User user = new User();
                        for (int c = 1; c < input.Length; c++)
                        {
                            user.comments.Add(input[c]);
                        }
                    user.name = input[0];
                    users.Add(user);
                } // update user comments
                else {
                        for (int c = 1; c < input.Length; c++)
                        {
                            users[userIndex].comments.Add(input[c]);
                        }
                }
                command = Console.ReadLine();
            }

            //sort dates
            for (int i = 0; i < users.Count; i++)
            {
                users[i].dates = users[i].dates.OrderBy(a => a).ToList();
            }

            // print result
            for (int user = 0; user < users.Count; user++)
            {
                if (users[user].dates.Count > 0)
                {
                    Console.WriteLine(users[user].name);
                    Console.WriteLine("Comments:");
                    for (int comment = 0; comment < users[user].comments.Count; comment++)
                    {
                        Console.WriteLine("- {0}", users[user].comments[comment]);
                    }

                    Console.WriteLine("Dates attended:");
                    for (int date = 0; date < users[user].dates.Count; date++)
                    {
                        Console.WriteLine("-- {0}", users[user].dates[date].ToString("dd/MM/yyyy", CultureInfo.InvariantCulture));
                    }    
                }
                       
                           
            }
        }
    }
}
