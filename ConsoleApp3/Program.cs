﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class multiply
{
    public static int mult(ref int a, int b, int c)
    {
        return a * b * c;
    }
    public static void Main1()
    {
        Console.WriteLine("Enter a:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter b:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter c:");
        int c = Convert.ToInt32(Console.ReadLine());

        int product = mult(ref a, b, c);
        Console.WriteLine($"Product is {product}");
    }
}
