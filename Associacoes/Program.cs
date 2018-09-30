using System;

namespace Associacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Digite os dados do fornecedor!--");
            Console.WriteLine("Nome");
            string nomeFornecedor = Console.ReadLine();
            Console.WriteLine("E-Mail");
            string emailFornecedor = Console.ReadLine();
            Console.WriteLine("Telefone");
            string telefoneFornecedor = Console.ReadLine();

            Fornecedor fornecedor = new Fornecedor(nomeFornecedor,emailFornecedor,telefoneFornecedor);

            //Criando produtos na mão para agilizar
            Produto desinfetante = new Produto("Desinfetante",9,14,fornecedor);
            Produto televisao = new Produto("Televisão",10000,3,fornecedor);
            Console.WriteLine(fornecedor);
            Console.WriteLine(desinfetante);
            Console.WriteLine(televisao);
        }
    }
}
