using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int personN = int.Parse(Console.ReadLine());
            int capacityP = int.Parse(Console.ReadLine());
            int courses = 0;
            if (personN > capacityP)
            {
                courses = personN / capacityP;
                int rest = personN % capacityP;
                if (rest > 0) { courses += 1; }
                Console.WriteLine(courses);
            }
            else { Console.WriteLine("1"); }
            
            
        }
    }
}
