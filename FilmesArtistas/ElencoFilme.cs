using System;
using System.Collections.Generic;
namespace FilmesArtistas{
    class ElencoFilme{
        public List<Artista> listaArtistasFilme;
        public Filme filme;
        //public CacheArtistaFilme cacheArtistaFilme; 
        public Agencia agencia;
     
    public ElencoFilme(Filme filme){
        this.filme = filme;
        agencia = new Agencia();
    }
    public void adicionaArtistaFilme(Artista artista){
        listaArtistasFilme.Add(artista);
    }    
    public override string ToString(){
        string retorno="Participações:"+"\n";
        foreach(Artista art in listaArtistasFilme){
            retorno+=art.ToString();
        }
        return retorno;
    }
  }
}