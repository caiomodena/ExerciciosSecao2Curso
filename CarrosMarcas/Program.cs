using System;

namespace CarrosMarcas
{
    class Program
    {
        static void Main(string[] args)
        {
            Concessionaria concessionaria = new Concessionaria();           
            Tela tela = new Tela();
            adicionaMarcasDefault();
            adicionaCarrosDefault();
            int opcao = 0;

            while(opcao!=7){
                tela.apresentaMenu();
                opcao = int.Parse(Console.ReadLine());
                switch(opcao){
                    case 1: tela.listaMarcas(concessionaria);
                            break;
                    case 2: tela.listaCarrosDeMarcaOrdenadamente(concessionaria);
                            break;
                    case 3: tela.cadastraMarca(concessionaria);
                            break;
                    case 7: Console.WriteLine("Fim!");
                            break; 
                }
            }
            void adicionaMarcasDefault(){
                concessionaria.cadastraMarcasPadrao(new Marca(1,"Chevrolet","Estados Unidos"));
                concessionaria.cadastraMarcasPadrao(new Marca(2,"Renault","França"));
            }
            void adicionaCarrosDefault(){
                concessionaria.retornaMarcaPorNome("Chevrolet").adicionaCarro(new Carro(1,"Cobalt",2014,50000));
                concessionaria.retornaMarcaPorNome("Chevrolet").adicionaCarro(new Carro(2,"Cruze",2012,70000));
                concessionaria.retornaMarcaPorNome("Renault").adicionaCarro(new Carro(1,"Fluence",2018,170000));
                concessionaria.retornaMarcaPorNome("Renault").adicionaCarro(new Carro(2,"Clio",2008,35000));
                concessionaria.retornaMarcaPorNome("Renault").adicionaCarro(new Carro(3,"Duster",2017,90000));
            }
        }
    }
}
