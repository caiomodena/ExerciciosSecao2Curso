using System;

namespace Teste{
    class Produto{
        public String nome{get;set;}
        public double preco{get;set;}
        public int quantidadeEmEstoque{get; set;}

        public double valorTotalEmEstoque(){
            return quantidadeEmEstoque*preco;
        }
        public void realizarEntrada(int quantidade){
            quantidadeEmEstoque+=quantidade;
        }
        public void realizarSaida(int quantidade){
            quantidadeEmEstoque-=quantidade;
        }
    }
}