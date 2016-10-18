using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace StudentGroups
{
    class Student {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
    class Town {
        public string Name { get; set; }
        public int SeatsCount { get; set; }
        public List<Student> Students { get; set; }
    }
    class Group {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Town> towns = new List<Town>();
            List<Group> groups = new List<Group>();
            String inputLine = Console.ReadLine();
            String[] input = inputLine.Split(' ');           
            int townIndex = -1;
            //bool hasTown = false;
            while (input[0] != "End")
            {
                input = inputLine.Split(' ');
                if (input[0] == "End") break;
                if (input[1] == "=>")
                { // add town   Plovdiv                 
                    Town newTown = new Town();
                    newTown.Name = input[0];
                    newTown.SeatsCount = int.Parse(input[2]);
                    newTown.Students = new List<Student>();
                    towns.Add(newTown);
                    townIndex++;
                } // Veliko Tarnovo
                else if (input[2] == "=>")
                {
                    Town newTown = new Town();
                    newTown.Name = input[0] + " " + input[1];
                    newTown.SeatsCount = int.Parse(input[3]);
                    newTown.Students = new List<Student>();
                    towns.Add(newTown);
                    townIndex++;
                }
                    // Add student
                else {
                    String[] inputStudent = inputLine.Split('|');
                    Student newStudent = new Student();
                    newStudent.Name = inputStudent[0].Trim();
                    newStudent.Email = inputStudent[1].Trim();
                    string format = "d-MMM-yyyy"; 
                    string date = inputStudent[2].Trim();
                    CultureInfo provider = CultureInfo.InvariantCulture;
                    DateTime studentDate = DateTime.ParseExact(date, format, null);                   
                    newStudent.RegistrationDate = studentDate;
                    
                    towns[townIndex].Students.Add(newStudent);
                }
                inputLine = Console.ReadLine();
            }

            // order towns by name ascending
            towns = towns.OrderBy(a => a.Name).ToList();

            // arrange groups
            for (int t = 0; t < towns.Count; t++)
            {
                IEnumerable<Student> students = towns[t].Students
                    .OrderBy(s => s.RegistrationDate)
                    .ThenBy(s => s.Name)
                    .ThenBy(s => s.Email);
                while (students.Any()) {
                    Group newGroup = new Group();
                    newGroup.Town = towns[t];
                    newGroup.Students = students.Take(newGroup.Town.SeatsCount).ToList();
                    students = students.Skip(newGroup.Town.SeatsCount);
                    groups.Add(newGroup);
                }
                
            }

            Dictionary<String, sbyte> townsCounter = new Dictionary<String, sbyte>();
            for (int i = 0; i < groups.Count; i++)
            {
                if (!townsCounter.ContainsKey(groups[i].Town.Name)) 
                    townsCounter.Add(groups[i].Town.Name, 0);
            }
            int townsTotal = townsCounter.Count;
            townsCounter.Clear();

            // print result
            Console.WriteLine("Created {0} groups in {1} towns:", groups.Count, townsTotal );
            for (int i = 0; i < groups.Count; i++)
            {
                Console.Write(groups[i].Town.Name + " => ");
                int commaCounter = 0;
                for (int s = 0; s < groups[i].Students.Count; s++)
                {
                    Console.Write("{0}{1}", groups[i].Students[s].Email,  
                    (commaCounter < groups[i].Students.Count - 1) ? ", " : "");
                    commaCounter++;
                }
                Console.WriteLine();
            }

            /*for (int i = 0; i < towns.Count; i++)
            {
                Console.WriteLine(towns[i].Name);
                for (int s = 0; s < towns[i].Students.Count; s++)
                {
                    Console.WriteLine("{0} | {1} | {2}", 
                        towns[i].Students[s].Name,
                        towns[i].Students[s].Email,
                        towns[i].Students[s].RegistrationDate.ToString("dd-MMM-yyyy"));
                }                
            }*/
        }
    }
}
