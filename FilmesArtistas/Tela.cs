using System;
namespace FilmesArtistas{
    class Tela{
        Agencia agencia = new Agencia();
        public static void mostrarMenu() {
            Console.WriteLine("1 - Listar artistas ordenadamente");
            Console.WriteLine("2 - Cadastrar artista");
            Console.WriteLine("3 - Cadastrar filme");
            Console.WriteLine("4 - Mostrar dados de um filme");
            Console.WriteLine("5 - Sair");
            Console.Write("Digite uma opção: ");
        }
        public static void adicionaArtista(){
            Console.Write("Código: ");
            int codigoArtista = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nomeArtista = Console.ReadLine();
            Console.Write("Cache: ");
            double cacheArtista = double.Parse(Console.ReadLine());            
            agencia.adicionaArtistas(new Artista(codigoArtista,nomeArtista,cacheArtista));
        }
        public string listaArtistas(){
            return agencia.ToString();
        }
    }
}