namespace HerancaPolimorfismo{
    class Retangulo:Figura{
        double altura;
        double largura;
        public Retangulo(double largura, double altura, string cor):base(cor){
            this.altura = altura;
            this.largura = largura;
        }
        public override double area(){
            return altura*largura;
        }
        public override double perimetro(){
            return 2*(altura+largura);
        }
    }
}