using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnglishNameOfTheLastDigit
{
    class Program
    {
        static string englishName(int num) { 
            int temp = num % 10;
            switch (temp) {
                case 0 : {return "zero";}
                case 1 : {return "one";}
                case 2 : {return "two";}
                case 3 : {return "three";}
                case 4 : {return "four";}
                case 5 : {return "five";}
                case 6 : {return "six";}
                case 7 : {return "seven";}
                case 8 : {return "eight";}
                case 9 : {return "nine";}
                default: { return "default case"; }
            }           
        }
        static void Main(string[] args)
        {
            Console.WriteLine(englishName(int.Parse(Console.ReadLine())));
        }
    }
}
