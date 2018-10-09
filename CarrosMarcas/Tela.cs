using System;
using System.Collections.Generic;
namespace CarrosMarcas{
    class Tela{
        public void apresentaMenu(){
            Console.WriteLine("1 - Listar Marcas");
            Console.WriteLine("2 - Listar carros de uma marca ordenadamente");
            Console.WriteLine("3 - Cadastrar Marca");
            Console.WriteLine("4 - Cadastrar Carro");
            Console.WriteLine("5 - Cadastrar Acessório");
            Console.WriteLine("6 - Mostrar detalhes de um carro");
            Console.WriteLine("7 - Sair");
        }
        public void listaMarcas(Concessionaria concessionaria){
            string retorno="-----LISTAGEM DE MARCAS-----"+"\n";
            foreach(Marca marca in concessionaria.retornaListaMarcas()){
                retorno+=marca.ToString();
                retorno+="\n";
            }            
            retorno+="------------------------------------";
            Console.WriteLine(retorno);
        }
        public void listaCarrosDeMarcaOrdenadamente(Concessionaria concessionaria){            
            Console.WriteLine("Digite o código da marca: ");
            int codigoMarca = int.Parse(Console.ReadLine());
            Marca marca = concessionaria.retornaMarcaPorCodigo(codigoMarca);
            string retorno="------Carros da Marca "+marca.nomeMarca+"-----------"+"\n";
            marca.retornaListaCarros().Sort();
            foreach(Carro carro in marca.retornaListaCarros()){
                retorno+=carro.ToString()+"\n";               
            }
            retorno+="------------------------------------";
            Console.WriteLine(retorno);
        }
        public void cadastraMarca(Concessionaria concessionaria){
            Console.WriteLine("Digite os dados da marca: ");
            Console.Write("Código: ");
            int codigoMarca = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nomeMarca = Console.ReadLine();
            Console.Write("País de Origem: ");
            string paisOrigemMarca = Console.ReadLine();            
            concessionaria.cadastraMarca(new Marca(codigoMarca,nomeMarca,paisOrigemMarca));
        }
    }
}