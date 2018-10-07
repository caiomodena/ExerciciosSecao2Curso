using System;
namespace FilmesArtistas{
    class Tela{
        Agencia agencia;
        Filme filme;
        ElencoFilme elencoFilme;
        public Tela(){
            agencia = new Agencia();
        }        
        public void mostrarMenu() {
            Console.WriteLine("1 - Listar artistas ordenadamente");
            Console.WriteLine("2 - Cadastrar artista");
            Console.WriteLine("3 - Cadastrar filme");
            Console.WriteLine("4 - Mostrar dados de um filme");
            Console.WriteLine("5 - Sair");
            Console.Write("Digite uma opção: ");
        }
        public void adicionaArtista(){
            Console.Write("Código: ");
            int codigoArtista = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nomeArtista = Console.ReadLine();
            Console.Write("Cache: ");
            double cacheArtista = double.Parse(Console.ReadLine());            
            agencia.adicionaArtistas(new Artista(codigoArtista,nomeArtista,cacheArtista));
        }
        public void listaArtistas(){            
            Console.WriteLine(agencia.ToString());
        }
        public void adicionaFilme(){
            Console.Write("Código: ");
            int codigoFilme = int.Parse(Console.ReadLine());
            Console.Write("Título: ");
            string nomeFilme = Console.ReadLine();
            Console.Write("Ano: ");
            int anoFilme = int.Parse(Console.ReadLine());
            filme = new Filme(codigoFilme,nomeFilme,anoFilme);
            elencoFilme = new ElencoFilme(filme);
        }
        public void adicionaElencoFilme(){
            Console.Write("Quantas participações tem o filme? ");
            int quantidadeParticipacoes = int.Parse(Console.ReadLine());
            for(int i=1;i<=quantidadeParticipacoes;i++){
                solicitaParticipacoesFilme(i);
            }
        }
        private void solicitaParticipacoesFilme(int numeradorParticipacao){
            Console.WriteLine("Digite os dados da "+numeradorParticipacao+"° participação:");
            Console.Write("Artista (código): ");            
            int codigoArtista = int.Parse(Console.ReadLine());
            Artista artista = agencia.retornaArtistaPorCodigo(codigoArtista);
            if(artista==null){
                throw new ModelException("Artista não existe!");
            }
            elencoFilme.adicionaArtistaFilme(artista);
            Console.Write("Desconto: ");
            double descontoValorCache = double.Parse(Console.ReadLine());
        }
    }
}