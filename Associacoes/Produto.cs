

namespace Associacoes{
    class Produto{

        string nomeProduto {get; set;}
        double precoProduto {get; set;}
        int quantidadeEmEstoque {get; set;}
        Fornecedor fornecedor;

        public Produto(string nomeProduto, double precoProduto, int quantidadeEmEstoque, Fornecedor fornecedor){
            this.nomeProduto = nomeProduto;
            this.precoProduto = precoProduto;
            this.quantidadeEmEstoque = quantidadeEmEstoque;
            this.fornecedor = fornecedor;
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
        public override string ToString(){
            return nomeProduto + ", "
            + fornecedor;
        }

    }
}