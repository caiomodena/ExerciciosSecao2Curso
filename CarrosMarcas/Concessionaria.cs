using System;
using System.Collections.Generic;
namespace CarrosMarcas{
    class Concessionaria{
        List<Marca> listaMarcas;
        public Concessionaria(){
            listaMarcas=new List<Marca>();            
        }
        public void cadastraMarcasPadrao(Marca marca){
            listaMarcas.Add(marca);
        }
        public void cadastraMarca(Marca marca){
            listaMarcas.Add(marca);
        }
        public Marca retornaMarcaPorNome(string nomeMarca){
            return listaMarcas.Find(x => x.nomeMarca==nomeMarca);
        }
        public List<Marca> retornaListaMarcas(){
            return listaMarcas;
        }
        public Marca retornaMarcaPorCodigo(int codigoMarca){
            return listaMarcas.Find(x => x.codigoMarca==codigoMarca);
        }
    }
}