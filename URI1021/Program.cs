using System;

namespace URI1021
{
    class Program
    {
        static void Main(string[] args) 
        {
        if (!decimal.TryParse(Console.ReadLine(), out var n)) return;
        var resto = (int)(n * 100);
        Console.WriteLine("NOTAS:");
        Console.WriteLine($"{resto / 10000} nota(s) de R$ 100.00");
        resto %= 10000;

        Console.WriteLine($"{resto / 5000} nota(s) de R$ 50.00");
        resto %= 5000;

        Console.WriteLine($"{resto / 2000} nota(s) de R$ 20.00");
        resto %= 2000;

        Console.WriteLine($"{resto / 1000} nota(s) de R$ 10.00");
        resto %= 1000;

        Console.WriteLine($"{resto / 500} nota(s) de R$ 5.00");
        resto %= 500;

        Console.WriteLine($"{resto / 200} nota(s) de R$ 2.00");
        Console.WriteLine("MOEDAS:");
        resto %= 200;

        Console.WriteLine($"{resto / 100} moeda(s) de R$ 1.00");
        resto %= 100;

        Console.WriteLine($"{resto / 50} moeda(s) de R$ 0.50");
        resto %= 50;

        Console.WriteLine($"{resto / 25} moeda(s) de R$ 0.25");
        resto %= 25;

        Console.WriteLine($"{resto / 10} moeda(s) de R$ 0.10");
        resto %= 10;

        Console.WriteLine($"{resto / 5} moeda(s) de R$ 0.05");
        resto %= 5;
        
        Console.WriteLine($"{resto} moeda(s) de R$ 0.01");
        }
    }
}