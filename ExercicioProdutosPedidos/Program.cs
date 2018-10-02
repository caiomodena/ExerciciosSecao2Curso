using System;

namespace ExercicioProdutosPedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            Estoque estoque = new Estoque();
            ItemPedido itemPedido = new ItemPedido();  
            Pedido pedido = new Pedido();
            int opcao = 1;
            while(opcao!=5){
                Console.WriteLine("--Menu de Produtos e Pedidos--");
                Console.WriteLine("1 - Listar produtos ordenadamente");
                Console.WriteLine("2 - Cadastrar produto");
                Console.WriteLine("3 - Cadastrar pedido");
                Console.WriteLine("4 - Mostrar dados de um pedido");
                Console.WriteLine("5 - Sair");
                Console.Write("Digite a opção desejada: ");
            
                opcao = int.Parse(Console.ReadLine());
            
                switch(opcao){
                    case 1: estoque.listaDeProdutos();
                            break;
                    case 2: estoque.cadastrarProdutoTela();
                            break;
                    case 3: itemPedido.cadastrarPedidoTela();
                            break;
                    case 4: pedido.selecionaDadosPedido();
                            break;
                    default: Console.WriteLine("Fim!");
                            break;
                }
            }
        }
    }
}
