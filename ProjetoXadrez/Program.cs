using System;
using tabuleiro;
using xadrez;

namespace ProjetoXadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                PartidaDeXadrez partida = new PartidaDeXadrez();
                while(!partida.terminada){
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tabuleiro);
                    Console.WriteLine();
                    Console.WriteLine("Turno: "+partida.turno); 
                    Console.WriteLine("Aguardando Jogada: "+partida.jogadorAtual); 
                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem=Tela.lerPosicaoXadrez().toPosicao();

                    partida.validarPosicaoDeOrigem(origem);
                    bool[,] posicoesPossiveis=tabuleiro.tabuleiro.peca(origem).movimentosPossiveis();
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tabuleiro,posicoesPossiveis);

                    Console.WriteLine();
                    Console.Write("Destino: ");
                    Posicao destino=Tela.lerPosicaoXadrez().toPosicao();
                    partida.validarPosicaoDeDestino(origem,destino);
                    partida.realizaJogada(origem,destino);
                }
                
            }
            catch(TabuleiroException ex){
                Console.WriteLine(ex.Message); 
                Console.ReadLine();
            }
        }
    }
}
