using System;
namespace HerancaPolimorfismo{
    class Triangulo:Figura{
        double lado1{get;}
        double lado2{get;}
        double lado3{get;}
        public Triangulo(double lado1, double lado2, double lado3,string cor):base(cor){
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }
        public override double area(){
            double p = (lado1+lado2+lado3)/2.0;
            return Math.Sqrt(p*(p-lado1)*(p-lado2)*(p-lado3));
        }
        public override double perimetro(){
            return lado1+lado2+lado3;
        }
    }
}