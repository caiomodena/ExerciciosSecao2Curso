using System;
using System.Collections.Generic;
namespace CarrosMarcas{
    class Marca{
        int codigoMarca;
        string nomeMarca;
        string paisOrigemMarca;
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
    }
}