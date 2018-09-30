namespace HerancaPolimorfismo{
    abstract class Figura{
        public string cor;
        public Figura(string cor){
            this.cor = cor;
        }
        public abstract double area();
        public abstract double perimetro();
    }
}