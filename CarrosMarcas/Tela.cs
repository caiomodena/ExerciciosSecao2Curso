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
        public void cadastraCarro(Concessionaria concessionaria){
            Console.WriteLine("Digite os dados do carro: ");
            Console.Write("Marca (código): ");
            int codigoMarca = int.Parse(Console.ReadLine());
            Marca marca = concessionaria.retornaMarcaPorCodigo(codigoMarca);
            cadastraCarroMarca(marca);
        }
        void cadastraCarroMarca(Marca marca){
            Console.Write("Código do carro: ");
            int codigoCarro = int.Parse(Console.ReadLine());
            Console.Write("Modelo: ");
            string modeloCarro = Console.ReadLine();
            Console.Write("Ano: ");
            int anoCarro = int.Parse(Console.ReadLine());
            Console.Write("Preço básico: ");
            double precoBasicoCarro = double.Parse(Console.ReadLine());
            marca.adicionaCarro(new Carro(codigoCarro,modeloCarro,anoCarro,precoBasicoCarro));
        }
        public void cadastraAcessorio(Concessionaria concessionaria){
            Console.WriteLine("Digite os dados do acessório: ");
            Console.Write("Carro (código): ");
            int codigoCarro = int.Parse(Console.ReadLine());
            Carro carro = buscaCarroPorCodigo(codigoCarro,concessionaria);           
            cadastraAcessorioCarro(carro);
        }
        void cadastraAcessorioCarro(Carro carro){
            Console.Write("Descrição: ");
            string descricaoAcessorio = Console.ReadLine();
            Console.Write("Preço: ");
            double precoAcessorio = double.Parse(Console.ReadLine());
            carro.adicionaAcessorio(new Acessorio(descricaoAcessorio,precoAcessorio));
        }
        public void listaDetalhesCarro(Concessionaria concessionaria){
            Console.Write("Digite o código do carro: ");
            int codigoCarro=int.Parse(Console.ReadLine());
            Carro carro = buscaCarroPorCodigo(codigoCarro,concessionaria);     
            Console.WriteLine(carro.ToString());
        }
        Carro buscaCarroPorCodigo(int codigoCarro,Concessionaria concessionaria){            
            Carro carro=new Carro();
            List<Marca> listaMarcas = concessionaria.retornaListaMarcas();
            foreach(Marca marca in listaMarcas){
                carro = marca.retornaCarroPorCodigo(codigoCarro);
            }
            return carro;
        }
    }
}