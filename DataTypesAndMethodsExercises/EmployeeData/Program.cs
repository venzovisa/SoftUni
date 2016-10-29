using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            ulong id = ulong.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Last name: " + lastName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + sex);
            Console.WriteLine("Personal ID: " + id);
            Console.WriteLine("Unique Employee number: " + number);
        }
    }
}
