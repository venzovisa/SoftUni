﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CircleArea12DigitsPrecision
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f12}", Math.PI * r * r);
        }
    }
}
