﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.Unicode;
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                Console.Write((char)i + " " );
            }
            Console.WriteLine();
        }
    }
}
