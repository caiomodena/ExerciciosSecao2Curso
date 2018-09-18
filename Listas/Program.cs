using System;
using System.Collections.Generic; 

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercício 1 
            /*List<string> lista = new List<string>(); 
            
            lista.Add("Caio");
            lista.Add("João");
            lista.Add("Ana");

            lista.Remove("João");
            lista.RemoveAt(0);

            int pos = lista.FindIndex(x => x == "Ana");

            Console.WriteLine("posição da Ana é: "+pos);

            for(int i=0;i<lista.Count;i++){
                Console.WriteLine(lista[i]);
            }
            */
            //Fim Exercício 1

            //Exercício 2 
            List<Funcionario> listaFuncionarios = new List<Funcionario>();
            int contadorFuncionarios=1;
            Console.WriteLine("Quantos funcionários serão cadastrados?");
            int quantidadeFuncionarios = int.Parse(Console.ReadLine());

            for(int contador=0;contador<quantidadeFuncionarios;contador++){
                Console.WriteLine("Dados do "+ contadorFuncionarios +"° funcionário: ");
                Console.WriteLine("CPF: " );
                string cpf = Console.ReadLine();
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Salário: ");
                double salario = Double.Parse(Console.ReadLine());

                listaFuncionarios.Add(new Funcionario(cpf, nome, salario));                

                contadorFuncionarios++;
            }

            Console.WriteLine("Digite o CPF do funcionário que terá aumento: ");
            string cpfFuncionarioAumento = Console.ReadLine();

            Console.WriteLine("Digite o percentual de aumento: ");
            double percentualAumento = Double.Parse(Console.ReadLine());

            foreach(Funcionario func in listaFuncionarios){
                if(func.cpfFuncionario == cpfFuncionarioAumento){
                    func.aumentarSalarioPorCpf(cpfFuncionarioAumento, percentualAumento);
                }
            }

            Console.WriteLine("-------Listagem atualizada de funcionários-------");
            foreach(Funcionario func in listaFuncionarios){
                Console.WriteLine(func.mostraFuncionario());
                //func.nomeFuncionario + 
            }

            //Fim Exercício 2 

        }
    }
}
