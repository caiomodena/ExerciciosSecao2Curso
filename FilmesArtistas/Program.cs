using System;
namespace FilmesArtistas{
    class Program{      
        Agencia agencia = new Agencia();
        static void Main(string[] args)
        {
            int opcao = 0;
            Tela tela = new Tela();

            while(opcao!=5){
                tela.mostrarMenu();
                try{
                    opcao = int.Parse(Console.ReadLine());
                }
                catch(ModelException exp){
                    Console.WriteLine(exp.Message);
                }
                catch(Exception exp){
                    Console.WriteLine(exp.Message + " Opção inexistente!");
                }
                switch(opcao){
                    case 1: tela.listaArtistas();
                            break;
                    case 2: tela.adicionaArtista();
                            break;
                    case 5: Console.WriteLine("Fim!");
                            break;                    
                }
            }           
        }
    }
}