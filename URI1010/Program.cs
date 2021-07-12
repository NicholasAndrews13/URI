using System;
using System.Globalization;

namespace URI1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int codPeca1, numeroPeca1, codPeca2, numeroPeca2;
            double total, valorUnitarioPeca1, valorUnitarioPeca2;

            string[] valores = Console.ReadLine().Split(' ');

            codPeca1 = int.Parse(valores[0]);
            numeroPeca1 = int.Parse(valores[1]);
            valorUnitarioPeca1 =double.Parse(valores[2],CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            
            codPeca2 = int.Parse(valores[0]);
            numeroPeca2 = int.Parse(valores[1]);
            valorUnitarioPeca2 = double.Parse(valores[2],CultureInfo.InvariantCulture);

            total = numeroPeca1 * valorUnitarioPeca1 + numeroPeca2 * valorUnitarioPeca2 ;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2",CultureInfo.InvariantCulture));
            
         }
    }     
}
