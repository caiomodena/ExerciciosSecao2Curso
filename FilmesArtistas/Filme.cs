using System;
using System.Collections.Generic;
namespace FilmesArtistas{
    class Filme{
        int codigoFilme;
        string nomeFilme;
        int anoLancamentoFilme;
        
        public Filme(int codigoFilme,string nomeFilme, int anoLancamentoFilme){
            this.codigoFilme = codigoFilme;
            this.nomeFilme = nomeFilme;
            this.anoLancamentoFilme = anoLancamentoFilme;
        }
        public override string ToString(){
            return "Filme "+codigoFilme
                +", Título: "+nomeFilme
                +", Ano:" +anoLancamentoFilme;
        }
    }
}