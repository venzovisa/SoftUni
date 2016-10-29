using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> squares = new List<int>();
            for (int i = 0; i < num.Count; i++)
            {
                if (Math.Sqrt(num[i]) == (int)(Math.Sqrt(num[i]))) {
                    squares.Add(num[i]);
                }
            }
            squares.Sort((a, b) => b.CompareTo(a));
            for (int i = 0; i < squares.Count; i++)
            {
                Console.Write(squares[i] + " ");
            }
        }
    }
}
