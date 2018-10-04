using System;
namespace FilmesArtistas{
    class Artista:IComparable{
        int codigoArtista;
        string nomeArtista;
        double cacheArtista {get;}
        public Artista(int codigoArtista,string nomeArtista,double cacheArtista){
            this.codigoArtista = codigoArtista;
            this.nomeArtista = nomeArtista;
            this.cacheArtista = cacheArtista;
        }

        public int CompareTo(object obj)
        {
            Artista artista = (Artista)obj;            
            return nomeArtista.CompareTo(artista.nomeArtista);            
        }      

        public override string ToString(){
            return codigoArtista + ", " +
                nomeArtista + ", " +
                "Cache: " + cacheArtista;
        }


    }
}