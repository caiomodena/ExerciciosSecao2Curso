
namespace Listas{

    class Funcionario{
        public string nomeFuncionario {get;}
        public string cpfFuncionario {get;}        
        public double salarioFuncionario {get; set;}
        public Funcionario(string CPFFuncionario, string NomeFuncionario, double salarioFuncionario){
            this.cpfFuncionario = CPFFuncionario;
            this.nomeFuncionario = NomeFuncionario;
            this.salarioFuncionario = salarioFuncionario;
        }

        public void aumentarSalarioPorCpf(string CPFFuncionario, double percentualAumento){
            //salarioFuncionario += (salarioFuncionario * (salarioFuncionario/percentualAumento));
            salarioFuncionario += (salarioFuncionario * (percentualAumento/100));
        }

        public string mostraFuncionario(){
            return cpfFuncionario + ", " + nomeFuncionario + ", " + salarioFuncionario.ToString(); 
        }

         
    }
}