/*using System;
using System.Numerics;

namespace DifferentIntegersSize
{
    class DifferentIntegersSize
    {
        static void Main()
        {
            BigInteger input = BigInteger.Parse(Console.ReadLine());
            bool isSbyte = (byte.MinValue <= input) && (input <= sbyte.MaxValue);
            bool isByte = (byte.MinValue <= input) && (input <= byte.MaxValue);
            bool isShort = (short.MinValue <= input) && (input <= short.MaxValue);
            bool isUshort = (ushort.MinValue <= input) && (input <= ushort.MaxValue);
            bool isInt = (int.MinValue <= input) && (input <= int.MaxValue);
            bool isUint = (uint.MinValue <= input) && (input <= uint.MaxValue);
            bool isLong = (long.MinValue <= input) && (input <= long.MaxValue);

            if (isSbyte || isByte || isShort || isUshort || isInt || isUint || isLong)
            {
                Console.WriteLine("{0} can fit in:", input);
                if (isSbyte)
                {
                    Console.WriteLine("* sbyte");
                }
                if (isByte)
                {
                    Console.WriteLine("* byte");
                }
                if (isShort)
                {
                    Console.WriteLine("* short");
                }
                if (isUshort)
                {
                    Console.WriteLine("* ushort");
                }
                if (isInt)
                {
                    Console.WriteLine("* int");
                }
                if (isUint)
                {
                    Console.WriteLine("* uint");
                }
                if (isLong)
                {
                    Console.WriteLine("* long");
                }
            }
            else
            {
                Console.WriteLine("{0} can't fit in any type", input);
            }
        }
    }
}*/

using System;
using System.Collections.Generic;
 
namespace DifferentIntegersSize
{
    class DifferentIntegersSize
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            List<string> numbers = new List<string>();
            sbyte s1 = 0;
            byte s2 = 0;
            short s3 = 0;
            ushort s4 = 0;
            int s5 = 0;
            uint s6 = 0;
            long s7 = 0;

            try
            {
                 s1 = sbyte.Parse(number);
                numbers.Add("* sbyte");
            }
            catch (OverflowException)
            {
            }
            try
            {
                s2 = byte.Parse(number);
                numbers.Add("* byte");
            }
            catch (OverflowException)
            {
            }
            try
            {
                s3 = short.Parse(number);
                numbers.Add("* short");
            }
            catch (OverflowException)
            {
            }
            try
            {
                s4 = ushort.Parse(number);
                numbers.Add("* ushort");
            }
            catch (OverflowException)
            {
            }
            try
            {
                s5 = int.Parse(number);
                numbers.Add("* int");
            }
            catch (OverflowException)
            {
            }
            try
            {
                s6 = uint.Parse(number);
                numbers.Add("* uint");
            }
            catch (OverflowException)
            {
            }
            try
            {
                s7 = long.Parse(number);
                numbers.Add("* long");
            }
            catch (OverflowException)
            {
            }
            if (numbers.Count > 0)
            {
                Console.WriteLine("{0} can fit in:", number);
                Console.WriteLine(string.Join("\n", numbers));
            }
            else
            {
                Console.WriteLine("{0} can't fit in any type", number);
            }
        }
    }
}