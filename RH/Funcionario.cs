using System;
using System.Globalization;

namespace RH
{
    class Funcionario{

        public String nome;
        public double salarioBruto;
        public double desconto;

        public Funcionario(String nome, double salarioBruto, double desconto){
            this.nome = nome;
            this.salarioBruto = salarioBruto;
            this.desconto = desconto;
        }

        public double salarioLiquido(){
            return salarioBruto - desconto;
        }
        public void aumentarSalario(double porcentagem){
            salarioBruto += (salarioBruto*(porcentagem/100));
        }
    }
}