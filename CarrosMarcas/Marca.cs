using System;
using System.Collections.Generic;
namespace CarrosMarcas{
    class Marca{
        public int codigoMarca;
        public string nomeMarca;
        public string paisOrigemMarca;
        List<Carro> listaCarros;
        public Marca(int codigoMarca,string nomeMarca,string paisOrigemMarca){
            this.codigoMarca=codigoMarca;
            this.nomeMarca=nomeMarca;
            this.paisOrigemMarca=paisOrigemMarca;
            listaCarros=new List<Carro>();
        }
        public void adicionaCarro(Carro carro){
            listaCarros.Add(carro);
        } 
        public List<Carro> retornaListaCarros(){
            return listaCarros;
        }
        public override string ToString(){
            string retorno="";
            int quantidadeCarros = listaCarros.Count;            
            retorno=codigoMarca+", "+nomeMarca+", País: "+paisOrigemMarca
                +", Número de Carros: "+quantidadeCarros;
            return retorno;
        }       
    }
}