using System;
namespace FilmesArtistas{
    class CacheArtistaFilme{
        public Filme filme;
        public Artista artista;
        public double cacheAposDesconto;
        public double valorDesconto;
        public CacheArtistaFilme(Filme filme, Artista artista,double valorDesconto){
            this.filme = filme;
            this.artista = artista;
            this.valorDesconto = valorDesconto;
        }
        public void calculaCacheAposDesconto(){
            cacheAposDesconto = (artista.cacheArtista-valorDesconto);
        }
        public override string ToString(){
            string retornoCache = "Desconto: "+valorDesconto
                +", Custo: "+cacheAposDesconto;
            return retornoCache;
        }
    }
}