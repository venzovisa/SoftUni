﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine(), 16);
            Console.WriteLine(num);
        }
    }
}
