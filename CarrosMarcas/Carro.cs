using System;
using System.Collections.Generic;
namespace CarrosMarcas{
    class Carro:IComparable{
        public int codigoCarro;
        string modeloCarro;
        int anoFabricacaoCarro;
        double precoBasicoCarro;
        List<Acessorio> listaAcessorios;
        public Carro(int codigoCarro,string modeloCarro,int anoFabricacaoCarro,double precoBasicoCarro){
            this.codigoCarro=codigoCarro;
            this.modeloCarro=modeloCarro;
            this.anoFabricacaoCarro=anoFabricacaoCarro;
            this.precoBasicoCarro=precoBasicoCarro;
            listaAcessorios=new List<Acessorio>();
        }    
        public Carro(){}  
        public void adicionaAcessorio(Acessorio acessorio){
            listaAcessorios.Add(acessorio);
        }  
        public double precoTotal(){
            double precoTotal=precoBasicoCarro;
            foreach(Acessorio acessorio in listaAcessorios){
                precoTotal+=acessorio.precoAcessorio;
            }
            return precoTotal;
        }        

        public int CompareTo(object obj)
        {
            Carro outroCarro=(Carro)obj;
            int comparacao=modeloCarro.CompareTo(outroCarro.modeloCarro);
            if(comparacao==0){
                return -(precoTotal().CompareTo(outroCarro.precoTotal()));
            }
            return comparacao;        
        }
        public override string ToString(){
            string retorno;
            retorno = codigoCarro+", "+modeloCarro+
                ", Ano:"+anoFabricacaoCarro+", Preço Básico: "+precoBasicoCarro
                + ", Preço total: "+precoTotal();
            if(listaAcessorios.Count>0){
                retorno+="\n"+"Acessórios: ";
                foreach(Acessorio acessorio in listaAcessorios){
                    retorno+="\n"+acessorio.descricaoAcessorio+", Preço: "
                        +acessorio.precoAcessorio;
                }
            }
            return retorno;
        }
    }
}