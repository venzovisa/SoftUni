/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());           
            Console.WriteLine(Convert.ToString(input, 16).ToUpper());
            Console.WriteLine(Convert.ToString(input, 2));
        }
    }
}*/

using System;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        String myHexNumber = n.ToString("X");

        Console.WriteLine(myHexNumber);

        int remainder;
        string result = string.Empty;
        while (n > 0)
        {
            remainder = n % 2;
            n /= 2;
            result = remainder.ToString() + result;
        }
        Console.WriteLine(result);
    }
}
