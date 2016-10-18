using System;


namespace PrimeChecker
{
    public class Program
    {
        static bool isPrime(ulong n) {
            if (n < 2) {return false;}
            else if (n == 2 || n == 3 || n == 5 || n == 7) { return true; }           
            else if (n % 2 != 0 && 
                     n % 3 != 0 &&
                     n % 5 != 0 &&
                     n % 7 != 0)
            { return true; }
            else
            { return false; } 
        }
        public static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            Console.WriteLine(isPrime(n));
        }
    }
}
