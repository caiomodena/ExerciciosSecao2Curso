using System;

namespace ElementosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Digite três números inteiros--");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int menorNumeroDigitado = Util.menorEntreTres(num1,num2,num3);
            Console.WriteLine("O menor número digitado é o: "+menorNumeroDigitado);
        }
    }
}
