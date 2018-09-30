namespace Excecoes{
    class Conta{
        public int numero{get; set;}
        public string titular{get; set;}
        public double saldo{get; private set;}
        public double limiteDeSaque{get; set;}
        public Conta(int numero, string titular,double limiteDeSaque){
            this.numero=numero;
            this.titular=titular;
            this.limiteDeSaque=limiteDeSaque;
            this.saldo=0;
        }
        public void depositar(double valor){
            saldo+=valor;
        }
        public void sacar(double valor){
            if(saldo<valor){
                throw new OperacaoException("Não há saldo suficiente!");
            }
            if(valor>limiteDeSaque){
                throw new OperacaoException("Valor do saque é superior ao limite da conta!");
            }
            saldo-=valor;
        }
    }
}