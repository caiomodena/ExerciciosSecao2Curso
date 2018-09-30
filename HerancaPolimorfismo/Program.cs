using System;
using System.Collections.Generic;

namespace HerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> listaFiguras = new List<Figura>();
            Console.Write("Quantas figuras você vai digitar?");
            int numeroFiguras = int.Parse(Console.ReadLine());

            for(int i=1;i<=numeroFiguras;i++){
                Console.Write("Figura "+ i + " - triângulo ou retângulo (t/r)? ");
                char caractereDigitado = char.Parse(Console.ReadLine());
                if(caractereDigitado=='r'){
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine());
                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine());
                    Figura retangulo = new Retangulo(largura,altura,"Amarelo");
                    listaFiguras.Add(retangulo); 
                }
                else{
                    Console.Write("Lado 1: ");
                    double lado1 = double.Parse(Console.ReadLine());
                    Console.Write("Lado 2: ");
                    double lado2 = double.Parse(Console.ReadLine());
                    Console.Write("Lado 3: ");
                    double lado3 = double.Parse(Console.ReadLine());
                    Figura triangulo = new Triangulo(lado1,lado2,lado3,"Azul");
                    listaFiguras.Add(triangulo); 
                }
            }
            Console.WriteLine();
            Console.WriteLine("Área das figuras: ");
            for(int i=0;i<numeroFiguras;i++){
                Console.WriteLine("Figura "+i+": "+listaFiguras[i].area());
            }

        }
    }
}
