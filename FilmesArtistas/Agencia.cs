using System;
using System.Collections.Generic;
namespace FilmesArtistas{
    class Agencia{
        List<Artista> listaArtistas;
        public Agencia(){
            listaArtistas = new List<Artista>();
            adicionaArtistasIniciais();
        }
        void adicionaArtistasIniciais(){
            listaArtistas.Add(new Artista(101,"Scarlett Johansson",4000000));
            listaArtistas.Add(new Artista(102,"Chris Evans",2500000));
            listaArtistas.Add(new Artista(103,"Robert Downey Jr.",3000000));
            listaArtistas.Add(new Artista(104,"Morgan Freeman",4000000));
        }
        public void adicionaArtistas(Artista artista){
            listaArtistas.Add(artista);
        }
        public override string ToString(){
            ordenaLista();
            string saida = "---------------"+"\n"+"LISTAGEM DE ARTISTAS";
            foreach(Artista artista in listaArtistas){
                saida += "\n"+artista.ToString();
            }
            return saida;
        }
        void ordenaLista(){
            listaArtistas.Sort();
        }
    }
}