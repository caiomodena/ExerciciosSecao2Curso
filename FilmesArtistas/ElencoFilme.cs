using System;
using System.Collections.Generic;
namespace FilmesArtistas{
    class ElencoFilme{
        public List<Artista> listaArtistasFilme;
        public Filme filme;
        //public CacheArtistaFilme cacheArtistaFilme; 
        public List<CacheArtistaFilme> listaCachesFilme;
     
    public ElencoFilme(Filme filme){
        this.filme = filme;
        listaArtistasFilme=new List<Artista>();     
        listaCachesFilme=new List<CacheArtistaFilme>();   
    }
    public void adicionaArtistaFilme(Artista artista){
        listaArtistasFilme.Add(artista);
    }    
    public void adicionaCachesFilme(CacheArtistaFilme cache){
        listaCachesFilme.Add(cache);
    }
    public override string ToString(){
        string retorno="Participações:"+"\n";
        foreach(Artista art in listaArtistasFilme){
            retorno+=art.ToString();
        }
        return retorno;
    }
    public int custoTotalElenco(){
        int custoTotal=0;
        foreach(CacheArtistaFilme cache in listaCachesFilme){
            custoTotal+=cache.cacheAposDesconto;
        }
    }
  }
}