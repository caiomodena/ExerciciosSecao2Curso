using System;
using System.Globalization;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vet;
            double soma=0;
            double media=0;

            int num = int.Parse(Console.ReadLine());

            vet = new double[num];

            for(int i = 0;i<num;i++){
                vet[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }

            for(int i=0;i<num;i++){
                soma+=vet[i];
            }
            
            media=soma/num;

            Console.WriteLine("Altura média: {0}",media.ToString("F2"));
        }
    }
}
