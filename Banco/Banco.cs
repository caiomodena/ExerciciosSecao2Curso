using System;
using System.Globalization;

namespace Banco
{
    class Banco{

        public int numeroConta {get; private set;}
        public string nomeTitularConta {get;set;}
        public double valorDepositoInicial {get; set;}
        public double saldo {get; private set;}

        public Banco(int numeroConta, string nomeTitularConta, double valorDepositoInicial){
            this.numeroConta = numeroConta;
            this.nomeTitularConta = nomeTitularConta;
            saldo = valorDepositoInicial;
        }
        public Banco(int numeroConta, string nomeTitularConta){
            this.numeroConta = numeroConta;
            this.nomeTitularConta = nomeTitularConta;
            saldo = 0;
        }

        public void depositar(double valor){
            saldo+=valor;
        }

        public void sacar(double valor){
            saldo-=(valor+5);
        }


    }
    
}