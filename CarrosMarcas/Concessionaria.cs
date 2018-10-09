using System;
using System.Collections.Generic;
namespace CarrosMarcas{
    class Concessionaria{
        List<Marca> listaMarcas;
        public Concessionaria(){
            listaMarcas=new List<Marca>();
            cadastraMarcasPadrao();
        }
        void cadastraMarcasPadrao(){
            listaMarcas.Add(new Marca(1,"Chevrolet","Estados Unidos"));
            listaMarcas.Add(new Marca(2,"Renault","França"));
        }
    }
}