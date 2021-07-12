﻿using System;
using System.Globalization;

namespace URI1036
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2;

            var input = Console.ReadLine().Split(' ');
            a = Convert.ToDouble(input[0]);
            b = Convert.ToDouble(input[1]);
            c = Convert.ToDouble(input[2]);

            if ((b * b - 4 * a * c) >= 0 && (2 * a) != 0)
            {
                x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

                x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

                Console.WriteLine("R1 = "+ x1.ToString("F5",CultureInfo.InvariantCulture));

                Console.WriteLine("R2 = "+ x2.ToString("F5",CultureInfo.InvariantCulture));

            }

            else
            {
                Console.WriteLine("Impossivel calcular");
            }
        }
    }
}
