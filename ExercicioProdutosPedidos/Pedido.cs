using System;
using System.Collections.Generic;
namespace ExercicioProdutosPedidos{
    class Pedido{
        int codigoPedido;
        DateTime dataPedido;
        List<Produto> listaProdutos;
        Estoque estoque;
        public Pedido(int codigoPedido,DateTime dataPedido){
            this.codigoPedido=codigoPedido;
            this.dataPedido=dataPedido;
            listaProdutos = new List<Produto>();
            estoque = new Estoque();
        }        
        
        public void adicionaProdutoPorCodigo(int codigoProduto){
            Produto produto = estoque.retornaListProdutos().Find(x => x.codigoProduto==codigoProduto);
            listaProdutos.Add(produto);
        }
        
    }
}