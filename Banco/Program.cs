using System;
using System.Globalization;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Digite o nome do titular da conta: ");
            string nomeTitular =  Console.ReadLine();

            Console.Write("Haverá depósito inicial <s/n>? ");
            char escolha = char.Parse(Console.ReadLine());

            if(escolha=='s'){
                Console.Write("Digite o valor do depósito inicial: ");
                double valorDeposito = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Banco banco1 = new Banco(numeroConta,nomeTitular,valorDeposito);

                Console.WriteLine("Conta criada: ");
                Console.WriteLine("Conta {0}, Titular: {1}, Saldo: R$ {2}",banco1.numeroConta,
                    banco1.nomeTitularConta,banco1.saldo);

                Console.Write("Digite um valor para depósito: ");
                double valorDeposito2 = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                banco1.depositar(valorDeposito2);

                Console.WriteLine("Conta {0}, Titular: {1}, Saldo: R$ {2}",banco1.numeroConta,
                    banco1.nomeTitularConta,banco1.saldo);
            }

            

        }
    }
}
