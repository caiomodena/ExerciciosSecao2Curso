using System;
using System.Collections.Generic;
namespace ExercicioProdutosPedidos{
    class Pedido{
        int codigoPedido {get;}
        DateTime dataPedido {get;}
        List<Produto> listaProdutos;
        List<ItemPedido> itensPedido;
        Estoque estoque;
        public Pedido(int codigoPedido,DateTime dataPedido){
            this.codigoPedido=codigoPedido;
            this.dataPedido=dataPedido;
            listaProdutos = new List<Produto>();
            estoque = new Estoque();
            itensPedido = new List<ItemPedido>();
        }        
        public Pedido(){
            
        }
        
        public void adicionaProdutoPorCodigo(int codigoProduto){
            Produto produto = estoque.retornaListProdutos().Find(x => x.codigoProduto==codigoProduto);
            listaProdutos.Add(produto);
        }
        public void selecionaDadosPedido(){
            Console.WriteLine("Digite o código do pedido: ");
            int codigoPedidoTela = int.Parse(Console.ReadLine());            

        }
        public override string ToString(){
            return "Pedido "+codigoPedido+", data: "+dataPedido;
        } 
        
    }
}