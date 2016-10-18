using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AverageGrades
{
    public class Student : IComparable<Student>
    {
        public string name;
        public List<float> grades;
        public float averageGrade;
        public int CompareTo(Student other)
        {
            return this.name.CompareTo(other.name);
        }
    }

    public class SortByName : IComparer<Student>{
        public int Compare(Student x, Student y){
        return x.name.CompareTo(y.name);
        }
    }

    public class Program
    {

        public static void Main(string[] args)
        {
            int amountOfStudents = int.Parse(Console.ReadLine());
            List<Student> list = new List<Student>();
            SortByName sortByName = new SortByName();           
            for (int i = 0; i < amountOfStudents; i++)
            {
                Student newStudent = new Student();
                string[] nameAndGrades = Console.ReadLine().Split(' ');
                newStudent.name = nameAndGrades[0];
                newStudent.grades = new List<float>();
                int numberOfGrades = 0;
                for (int grade = 1; grade < nameAndGrades.Length; grade++)
                {
                    newStudent.grades.Add(float.Parse(nameAndGrades[grade]));
                    newStudent.averageGrade += float.Parse(nameAndGrades[grade]);
                    numberOfGrades++;
                }
                newStudent.averageGrade = newStudent.averageGrade / numberOfGrades;
                list.Add(newStudent);
            }

            list = list
                .OrderBy(a => a.averageGrade >= 5.00)
                .ThenBy(a => a.name)
                .ThenByDescending(a => a.averageGrade)
                .ToList();
            
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].averageGrade >= 5.00)
                    Console.WriteLine("{0} -> {1:f2}", list[i].name, list[i].averageGrade);
            }
        }                    
    }
}
