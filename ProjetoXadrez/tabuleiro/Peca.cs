namespace tabuleiro{
    abstract class Peca{
        public Posicao posicao {get;set;}
        public Cor cor{get;protected set;}
        public int qtdMovimentos{get;protected set;}
        public Tabuleiro tabuleiro{get; protected set;}
        public Peca(Tabuleiro tabuleiro, Cor cor){
            this.posicao=null;
            this.tabuleiro=tabuleiro;
            this.cor=cor;
            qtdMovimentos=0;
        }
        public void incrementarQteMovimentos(){
            qtdMovimentos++;
        }
        public void decrementarQteMovimentos(){
            qtdMovimentos--;
        }
        public bool existeMovimentosPossiveis(){
            bool[,] mat = movimentosPossiveis;
            for(int i=0;i<tabuleiro.linhas;i++){
                for(int j=0;j<tabuleiro.colunas;j++){
                    if(mat[i,j]==true){
                        return true;   
                    }
                }
            }
            return false;
        }
        public bool podeMoverPara(Posicao pos){
            return movimentosPossiveis()[pos.linha,pos.coluna];
        }
        public abstract bool[,] movimentosPossiveis();

    }
}