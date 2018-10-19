namespace tabuleiro{
    class Tabuleiro{
        public int linhas{get;set;}
        public int colunas{get;set;}
        Peca[,] pecas;
        public Tabuleiro(int linhas,int colunas){
            this.linhas=linhas;
            this.colunas=colunas;
            pecas=new Peca[linhas,colunas];
        }
        public Peca peca(int linha,int coluna){
            return pecas[linha,coluna];
        }
        public void colocarPeca(Peca peca, Posicao pos){
            pecas[pos.linha,pos.coluna] = peca;
            peca.posicao = pos;
        }
    }
}