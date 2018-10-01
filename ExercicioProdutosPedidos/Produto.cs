using System;
namespace ExercicioProdutosPedidos{
    class Produto{
        public int codigoProduto {get;}
        string descricaoProduto;
        double precoProduto;
        public Produto(int codigoProduto,string descricaoProduto,double precoProduto){
            this.codigoProduto=codigoProduto;
            this.descricaoProduto=descricaoProduto;
            this.precoProduto=precoProduto;
        }
        public override string ToString(){
            return codigoProduto+", "+descricaoProduto+", "+precoProduto;
        }
    }
}