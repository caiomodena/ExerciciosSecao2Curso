using System;
namespace FilmesArtistas{
    class Artista{
        int codigoArtista;
        string nomeArtista;
        double cacheArtista;
        public Artista(int codigoArtista,string nomeArtista,double cacheArtista){
            this.codigoArtista = codigoArtista;
            this.nomeArtista = nomeArtista;
            this.cacheArtista = cacheArtista;
        }
        public override string ToString(){
            return codigoArtista + ", " +
                nomeArtista + ", " +
                "Cache: " + cacheArtista;
        }

    }
}