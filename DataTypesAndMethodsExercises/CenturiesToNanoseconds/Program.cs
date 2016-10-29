using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong input = ulong.Parse(Console.ReadLine());
            ulong years = input * 100;
            BigInteger days = (BigInteger)(years * 365.2424);
            BigInteger hours = (days * 24);
            BigInteger minutes = (hours * 60);
            BigInteger seconds = (minutes * 60);
            BigInteger milliseconds = (seconds * 1000);
            BigInteger microseconds = (milliseconds * 1000);
            BigInteger nanoseconds = (microseconds * 1000);            
            Console.Write(input + " centuries = ");
            Console.Write(years + " years = ");
            Console.Write(days + " days = ");
            Console.Write(hours + " hours = ");
            Console.Write(minutes + " minutes = ");
            Console.Write(seconds + " seconds = ");
            Console.Write(milliseconds + " milliseconds = ");
            Console.Write(microseconds + " microseconds = ");
            Console.Write(nanoseconds + " nanoseconds");            
        }
    }
}
