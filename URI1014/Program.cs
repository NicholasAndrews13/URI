﻿using System;
using System.Globalization;

namespace URI1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Y, kml;

            X = int.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            kml = X / Y;

            Console.WriteLine(kml.ToString("F3",CultureInfo.InvariantCulture) + " km/l");
        }
    }
}