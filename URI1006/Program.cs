using System;
using System.Globalization;

namespace URI1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, media;
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (x * 2.0 + y * 3.0 + z * 5.0)/10.0;
            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
