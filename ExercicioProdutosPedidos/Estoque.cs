using System;
using System.Collections.Generic;

namespace ExercicioProdutosPedidos{
    class Estoque{
        List<Produto> listaProdutos = new List<Produto>();

        public Estoque(){
            adicionaProdutosAutomaticamente();
        }
        public void cadastrarProdutoTela(){
            Console.WriteLine("Digite os dados do produto");
            Console.Write("Código: ");
            int codigoProduto = int.Parse(Console.ReadLine());
            Console.Write("Descrição: ");
            string descricaoProduto = Console.ReadLine();
            Console.Write("Preço: ");
            double precoProduto = double.Parse(Console.ReadLine());
            Produto produto = new Produto(codigoProduto,descricaoProduto,precoProduto);
            listaProdutos.Add(produto);
        }
        private void cadastrarProduto(Produto produto){
            listaProdutos.Add(produto);
        }
        public void listaDeProdutos(){
            foreach(Produto produto in listaProdutos){
                Console.WriteLine(produto);
            }
        }
        public List<Produto> retornaListProdutos(){
            return listaProdutos;
        }
        private void adicionaProdutosAutomaticamente(){
            Produto p1 = new Produto(1001,"Cadeira simples",500);
            Produto p2 = new Produto(1002,"Cadeira acolchoada",900);
            Produto p3 = new Produto(1003,"Sofá de três lugares",2000);
            Produto p4 = new Produto(1004,"Mesa retangular",1500);
            Produto p5 = new Produto(1005,"Mesa retangular",2000);
            cadastrarProduto(p1);
            cadastrarProduto(p2);
            cadastrarProduto(p3);
            cadastrarProduto(p4);
            cadastrarProduto(p5);
        }
    }
}