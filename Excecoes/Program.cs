using System;

namespace Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados da conta");
            Console.Write("Número: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Nome do titular: ");
            string titularConta = Console.ReadLine();
            Console.Write("Limite de saque: ");
            double limiteDeSaque = double.Parse(Console.ReadLine());

            Conta conta = new Conta(numeroConta,titularConta,limiteDeSaque);

            Console.Write("Digite valor a ser depositado: ");
            double valorDepositado = double.Parse(Console.ReadLine());

            conta.depositar(valorDepositado);

            Console.Write("Digite valor a ser sacado: ");
            double valorASacar = double.Parse(Console.ReadLine());

            try{
                conta.sacar(valorASacar);
            }
            catch(OperacaoException o){
                Console.WriteLine(o.Message);
            }
        }
    }
}
