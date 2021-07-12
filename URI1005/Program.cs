using System;
using System.Globalization;

namespace URI1005
{
    class Program
    {
        static void Main(string[] args)
        {
           double x, y, media;
           x= double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
           y= double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

           media = ((x * 3.5 + y * 7.5)/(3.5 + 7.5));
           Console.WriteLine("MEDIA = " + media.ToString("F5",CultureInfo.InvariantCulture));
        }
    }
}
