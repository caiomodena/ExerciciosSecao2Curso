using System;
using System.Collections.Generic;
namespace ExercicioProdutosPedidos{
    class ItemPedido{
        Pedido pedido;
        //Produto produto;        
        
        public void cadastrarPedidoTela(){
            Console.WriteLine("Digite os dados do pedido");
            Console.Write("Código: ");
            int codigoPedido = int.Parse(Console.ReadLine());
            Console.Write("Data: ");
            DateTime dataPedido = DateTime.Parse(Console.ReadLine());            
            pedido = new Pedido(codigoPedido,dataPedido);   
            cadastrarItensPedidoTela();         
        }
        private void cadastrarItensPedidoTela(){
            Console.Write("Quantos itens têm o pedido?");
            int quantidadeItensPedido = int.Parse(Console.ReadLine());
            for(int i=1;i<=quantidadeItensPedido;i++){
                Console.WriteLine("Digite os dados do "+i+"° item");
                Console.Write("Produto (código): ");
                int codigoProduto = int.Parse(Console.ReadLine());
                pedido.adicionaProdutoPorCodigo(codigoProduto);
                //Console.Write("Quantidade: ");
                //int quantidadeProduto = int.Parse(Console.ReadLine());
                //Console.Write("Percentual de desconto");
                //double percentualDesconto = double.Parse(Console.ReadLine());
            }
            
        }
        
    }
}