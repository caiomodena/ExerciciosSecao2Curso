using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz;
            int numero;

            numero = int.Parse(Console.ReadLine()); 
            
            matriz = new int[numero,numero];

            for(int i=0;i<numero;i++){
                string[] linhaDigitada = Console.ReadLine().Split(' ');
                for(int j=0;j<numero;j++){
                    matriz[i,j] = int.Parse(linhaDigitada[j]);
                }
            }

            Console.WriteLine("Diagonal Principal: ");
            for(int i=0;i<numero;i++){                
                Console.Write(matriz[i,i]+" ");
            }
            Console.WriteLine();

            int contadorNegativos=0;
            
            for(int j=0;j<numero;j++){
                for(int a=0;a<numero;a++){
                    if(matriz[j,a]<0){
                        contadorNegativos++;
                    }
                }
            }
            Console.WriteLine("Quantidade de negativos: ");
            Console.Write(contadorNegativos);
        }
    }
}
