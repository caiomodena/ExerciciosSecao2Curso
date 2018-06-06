using System;
using System.Globalization;

namespace Banco
{
    class Banco{

        int numeroConta;
        String nomeTitularConta {set;}
        double valorDepositoInicial;
        double saldo;

        public Banco(int numeroConta, String nomeTitularConta, double valorDepositoInicial){
            this.numeroConta = numeroConta;
            this.nomeTitularConta = nomeTitularConta;
            this.valorDepositoInicial = valorDepositoInicial;
        }
        public Banco(int numeroConta, String nomeTitularConta){
            this.numeroConta = numeroConta;
            this.nomeTitularConta = nomeTitularConta;
            valorDepositoInicial = 0;
        }

        public void depositar(double valor){
            saldo+=valor;
        }

        public void sacar(double valor){
            saldo-=(valor+5);
        }


    }
    
}