using System;
using System.Collections.Generic;
namespace FilmesArtistas{
    class ElencoFilme{
        public List<Artista> listaArtistasFilme;
        public Filme filme;
        public double descontoCache;
    
    public ElencoFilme(List<Artista> listaArtistasFilme,Filme filme){
        this.listaArtistasFilme = listaArtistasFilme;
        this.filme = filme;
    }
    public int calculaCacheFilme(Artista artista){
        return artista.cacheArtista()-descontoCache;
    }
    public void adicionaArtistaFilme(Artista artista){
        listaArtistasFilme.Add(artista);
    }
    public Artista retornaArtistaPorCodigo(int codigo){
        return listaArtistasFilme.Find(art => art.cacheArtista() == codigo);
    }
  }
}