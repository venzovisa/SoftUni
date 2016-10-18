using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace DebuggingExerciseInstructionSet
{
    public class Program
    {

        public static void Main()
        {
            decimal result = 0;
            string[] str = Console.ReadLine().ToLower().Split(' ');
            while (str[0] != "end") {             
                    switch (str[0]) {
                    case "inc" : { result = long.Parse(str[1])+1; break; }
                    case "dec": { result =  long.Parse(str[1])-1; break; }
                    case "add": { result =  long.Parse(str[1]) + long.Parse(str[2]); break; }
                    case "mla": { result =  decimal.Parse(str[1]) * decimal.Parse(str[2]); break; }
                    //case "end" : { Console.WriteLine(); break; }
                    default: { Console.WriteLine("Wrong command"); break; }
                }                            
                str = Console.ReadLine().ToLower().Split(' ');
                Console.WriteLine(result); 
            }
                      
        }
    }
}
