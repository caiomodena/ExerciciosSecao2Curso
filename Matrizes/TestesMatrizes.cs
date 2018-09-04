using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 1 
            /*
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
         */
         //Exercício 2
         int[,] Matriz;
         int numeroLinhas;
         int numeroColunas;

         Console.WriteLine("Digite número de linhas: ");
         numeroLinhas = int.Parse(Console.ReadLine());

         Console.WriteLine("Digite número de colunas: ");
         numeroColunas = int.Parse(Console.ReadLine());
         
         Matriz = new int[numeroLinhas,numeroColunas];

         Console.WriteLine("Números: ");
         int linha;
         for(int i=0;i<numeroLinhas;i++)
         {
             for(int j=0;j<numeroColunas;j++)
             {
                linha = int.Parse(Console.ReadLine());
                //for(int a=0;a<(numeroLinhas*numeroColunas);a++)
                //{
                    //Console.WriteLine("oi");
                   //if(linha==Matriz[a,j]){
                   //         Console.WriteLine("Erro!!!!");
               //             break;
                //    }
                //}
                Matriz[i,j] = linha;
             }
         }
         Console.WriteLine("Digite número para ser pesquisado na matriz: ");
         int numeroPesquisaMatriz = int.Parse(Console.ReadLine());
         bool numeroExiste = false;
         for(int i=0;i<numeroLinhas;i++)
         {
             for(int j=0;j<numeroColunas;j++)
             {
                 if(Matriz[i,j]==numeroPesquisaMatriz){
                     numeroExiste = true;
                 }
             }
         }
         if(numeroExiste){
             Console.WriteLine("Número Existe!");
         }
      }
    }
}
