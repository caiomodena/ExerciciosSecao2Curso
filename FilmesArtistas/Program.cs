using System;
namespace FilmesArtistas{
    class Program{      
        Agencia agencia = new Agencia();
        static void Main(string[] args)
        {
            int opcao = 0;

            while(opcao!=5){
                Tela.mostrarMenu();
                try{
                    opcao = int.Parse(Console.ReadLine());
                }
                catch(ModelException exp){
                    Console.WriteLine(exp.Message);
                }
                switch(opcao){
                    case 1: Tela.listaArtistas();
                            break;
                    case 2: Tela.adicionaArtista();
                            break;
                    default: "Opção inexistente!";
                             break;        

                }
            }
            Console.WriteLine("Fim!");
        }
    }
}