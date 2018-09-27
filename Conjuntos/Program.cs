using System;
using System.Collections.Generic;

namespace Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            //HashSet não aceita repetições 
            //Exercicio 1
            /*
            HashSet<int> conjuntoInteirosA = new HashSet<int>();
            HashSet<int> conjuntoInteirosB = new HashSet<int>(); 
            
            conjuntoInteirosA.Add(3);
            conjuntoInteirosA.Add(5);
            conjuntoInteirosA.Add(8);
            conjuntoInteirosA.Add(9);

            conjuntoInteirosB.Add(3);
            conjuntoInteirosB.Add(4);
            conjuntoInteirosB.Add(5);

            conjuntoInteirosA.ExceptWith(conjuntoInteirosB);
            conjuntoInteirosB.UnionWith(conjuntoInteirosA);
            conjuntoInteirosA.IntersectWith(conjuntoInteirosB);

            foreach(int numero in conjuntoInteirosA){
                Console.WriteLine(numero); 
            }

            Console.WriteLine("Digite um número inteiro: ");

            int numeroDigitado = int.Parse(Console.ReadLine());

            if(conjuntoInteirosA.Contains(numeroDigitado))
            {
                Console.WriteLine(numeroDigitado + " pertence ao conjunto!!!");
            }

            //conjuntoInteirosA.Remove(3);
             */

             //Exercício 2
            Console.WriteLine("O curso A possui quantos alunos? ");
            int qtdAlunosCursoA = int.Parse(Console.ReadLine());
             
            HashSet<int> alunosCursoA = new HashSet<int>();

            Console.WriteLine("--Digite os códigos dos alunos do curso A--");
            
            for(int i=0;i<qtdAlunosCursoA;i++){
                alunosCursoA.Add(int.Parse(Console.ReadLine()));
            }

            //--
             Console.WriteLine("O curso B possui quantos alunos? ");
            int qtdAlunosCursoB = int.Parse(Console.ReadLine());
             
            HashSet<int> alunosCursoB = new HashSet<int>();

            Console.WriteLine("--Digite os códigos dos alunos do curso B--");
            
            for(int i=0;i<qtdAlunosCursoB;i++){
                alunosCursoB.Add(int.Parse(Console.ReadLine()));
            }

            alunosCursoA.UnionWith(alunosCursoB);

            Console.WriteLine("O professor Geromel possui um total de " + alunosCursoA.Count 
                + " alunos." );
        }
    }
}
