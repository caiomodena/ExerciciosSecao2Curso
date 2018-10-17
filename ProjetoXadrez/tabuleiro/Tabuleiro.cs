namespace tabuleiro{
    class Tabuleiro{
        public int linhas{get;set;}
        public int colunas{get;set;}
        Peca[,] pecas;
        public Tabuleiro(int linhas,int colunas){
            this.linha=linha;
            this.coluna=coluna;
            pecas=new Peca[linhas,colunas];
        }
    }
}