using System;
using System.Globalization;

namespace Teste
{
    class Tela
    {
        static void Main(string[] args)
        {
            Produto prod = new Produto();
            Console.WriteLine("Digite os dados do produto:");
            Console.WriteLine("Nome: ");
            prod.nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            prod.preco = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade em estoque: ");
            prod.realizarEntrada(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dados do produto: {0}, R${1}, {2} unidades. Total: {3}",
                    prod.nome, prod.preco.ToString("F2",CultureInfo.InvariantCulture), prod.quantidadeEmEstoque,prod.valorTotalEmEstoque());

            Console.WriteLine("Digite a quantidade de produtos que entraram no estoque: ");
            prod.realizarEntrada(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dados atualizados: {0}, R${1}, {2} unidades. Total: {3}",
                    prod.nome, prod.preco.ToString("F2",CultureInfo.InvariantCulture), prod.quantidadeEmEstoque,prod.valorTotalEmEstoque());

            Console.WriteLine("Digite a quantidade de produtos que saíram do estoque: ");
            prod.realizarSaida(int.Parse(Console.ReadLine()));

            Console.WriteLine("Dados atualizados: {0}, R${1}, {2} unidades. Total: {3}",
                    prod.nome, prod.preco.ToString("F2",CultureInfo.InvariantCulture), prod.quantidadeEmEstoque,prod.valorTotalEmEstoque());
        }
    }
}
