using System;

namespace uri
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores=Console.ReadLine().Split(' ');

            int A = Int16.Parse(valores[0]);
            int B = Int16.Parse(valores[1]);
            int C = Int16.Parse(valores[2]);
            int D = Int16.Parse(valores[3]);

            if (B>C && D >A && C + D > A + B && C > 0 && D > 0 && A % 2 ==0){
                Console.WriteLine("Valores aceitos");
            }
            else{
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
