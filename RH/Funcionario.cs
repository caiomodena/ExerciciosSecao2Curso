using System;
using System.Globalization;

namespace RH
{
    class Funcionario{

        public String nome;
        private double salarioBruto {get; set;}
        private double desconto {get; set;}

        public Funcionario(String nome, double salarioBruto, double desconto){
            this.nome = nome;
            this.salarioBruto = salarioBruto;
            this.desconto = desconto;
        }

        public Funcionario(String nome){
            this.nome = nome;
            this.salarioBruto = 0;
            this.desconto = 0;
        }

        public double salarioLiquido(){
            return salarioBruto - desconto;
        }
        public void aumentarSalario(double porcentagem){
            salarioBruto += (salarioBruto*(porcentagem/100));
        }
    }
}