namespace Associacoes{
    class Fornecedor{
        string nomeFornecedor;
        string emailFornecedor;
        string telefoneFornecedor;

        public Fornecedor(string nomeFornecedor, string emailFornecedor, string telefoneFornecedor){
            this.nomeFornecedor = nomeFornecedor;
            this.emailFornecedor = emailFornecedor;
            this.telefoneFornecedor = telefoneFornecedor;
        }
        public override string ToString(){
            return nomeFornecedor + ", "
                + emailFornecedor + ", "
                + telefoneFornecedor + ".";
        }
    }
}