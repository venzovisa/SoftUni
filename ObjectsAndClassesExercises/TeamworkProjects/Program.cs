using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamworkProjects
{
    public class Team {
        public String teamName;
        public String creatorName;
        public List<String> users = new List<String>();
    }
    public class Program
    {
        static void Main(string[] args)
        {
            String command = "";
            List<Team> teams = new List<Team>();
            int registerTeams = int.Parse(Console.ReadLine());
            //List<String> regMessages = new List<string>();
            for (int i = 0; i < registerTeams; i++)
            {
                Team newTeam = new Team();
                String[] input = Console.ReadLine().Split('-');
                String userName = input[0];
                String teamName = input[1];

                bool hasTeam = false;
                bool hasCreator = false;

                // check team
                for (int t = 0; t < teams.Count; t++)
                {
                    if (teams[t].teamName == teamName)
                    {                       
                        hasTeam = true;
                        break;
                    }
                }

                // check creator
                for (int c = 0; c < teams.Count; c++)
                {
                    if (teams[c].creatorName == userName)
                    {                        
                        hasCreator = true;
                        break;
                    }
                }

                if (!hasTeam && hasCreator)
                {
                    //regMessages.Add(userName + " cannot create another team!");
                    Console.WriteLine("{0} cannot create another team", userName);
                }
                else if (hasTeam)
                {
                    //regMessages.Add("Team " + teamName + " was already created!");
                    Console.WriteLine("Team {0} was already created!", teamName);
                }
                else {
                    newTeam.creatorName = userName;
                    newTeam.teamName = teamName;
                    teams.Add(newTeam);
                    Console.WriteLine("Team {0} has been created by {1}!",
                   teamName, userName);
                }
                
            } // eof register

            // print register messages
            /*regMessages = regMessages               
                .OrderByDescending(a => a)
                .ToList();
            for (int i = 0; i < regMessages.Count; i++)
            {
                Console.WriteLine(regMessages[i]);
            }*/

            // print created by messages

            //teams = teams.OrderBy(a => a.creatorName).ToList();

            /*for (int i = 0; i < teams.Count; i++)
            {
                Console.WriteLine("Team {0} has been created by {1}!",
                    teams[i].teamName, teams[i].creatorName);
            }*/

            // add members
            command = Console.ReadLine();
            while (command != "end of assignment")
            {                
                String[] input = command.Split('-');
                String userName = input[0];
                String teamName = "";
                if (input[1][0] == '>')
                {
                    teamName = input[1].TrimStart('>');
                }
                else teamName = input[1];
               
                bool hasTeam = false;
                bool hasCreator = false;
                bool hasUser = false;
                int teamIndex = 0;
                
                // check team
                for (int i = 0; i < teams.Count; i++)
			    {
                    if (teams[i].teamName == teamName) {
                        teamIndex = i;
                        hasTeam = true;
                        break; }
			    }

                // check creator
                for (int i = 0; i < teams.Count; i++)
                {
                    if (teams[i].creatorName == userName)
                    {
                        teamIndex = i;
                        hasCreator = true;
                        break;
                    }
                }

                // check users
                for (int i = 0; i < teams.Count; i++)
                {
                    for (int u = 0; u < teams[i].users.Count; u++)
                    {
                        if (teams[i].users[u] == userName)
                        {                        
                            hasUser = true;
                            break;
                        }
                    }
                    if (hasUser) break;
                }                

                // add new member
                if (hasTeam && !hasCreator && !hasUser)
                {
                    teams[teamIndex].users.Add(userName);
                }                
                else if ((hasTeam && hasCreator) || (hasTeam && hasUser))
                {
                    Console.WriteLine("Member {0} cannot join team {1}!",
                    userName, teamName);
                }                               
                 // update existing team
                else if (!hasTeam)
                {
                    Console.WriteLine("Team {0} does not exist!", teamName);
                }
                command = Console.ReadLine();
            }           
          

            // print teams
            teams = teams.OrderBy(a => a.teamName).ToList();
            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].users.Count > 0) {
                    Console.WriteLine(teams[i].teamName);
                    Console.WriteLine("- {0}", teams[i].creatorName);
                    for (int u = 0; u < teams[i].users.Count; u++)
                    {
                        Console.WriteLine("-- {0}", teams[i].users[u]);
                    }
                }                
            }

            // Teams to disband
            List<Team> disbanded = new List<Team>();
            disbanded = teams.Where(a => a.users.Count == 0).ToList();
            disbanded = disbanded.OrderBy(a => a.teamName).ToList();
            Console.WriteLine("Teams to disband:");
            if (disbanded.Count > 0) {               
                for (int i = 0; i < disbanded.Count; i++)
                {
                    Console.WriteLine(disbanded[i].teamName);
                    /*Console.WriteLine("- {0}", disbanded[i].creatorName);
                    for (int u = 0; u < disbanded[i].users.Count; u++)
                    {
                        Console.WriteLine(disbanded[i].users[u]);
                    }*/
                }
            }
            
        }
    }
}
