

namespace Associacoes{
    class Produto{

        string nomeProduto;
        double precoProduto;
        int quantidadeEmEstoque;

        public Produto(string nomeProduto, double precoProduto, int quantidadeEmEstoque){
            this.nomeProduto = nomeProduto;
            this.precoProduto = precoProduto;
            this.quantidadeEmEstoque = quantidadeEmEstoque;
        }

        public double valorTotalEmEstoque(){
            return quantidadeEmEstoque;
        }
        public void realizarEntrada(int quantidade){
            quantidadeEmEstoque+=quantidade;
        }
        public void realizarSaida(int quantidade){
            quantidadeEmEstoque+=quantidade;
        }

    }
}