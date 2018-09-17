
namespace Listas{

    class Funcionario{
        string nomeFuncionario {get;}
        string cpfFuncionario {get;}        
        double salarioFuncionario {get; set;}
        public Funcionario(string CPFFuncionario, string NomeFuncionario, double salarioFuncionario){
            this.cpfFuncionario = CPFFuncionario;
            this.nomeFuncionario = NomeFuncionario;
            this.salarioFuncionario = salarioFuncionario;
        }

        public void aumentarSalarioPorCpf(string CPFFuncionario, double percentualAumento){
            salarioFuncionario += (salarioFuncionario * (salarioFuncionario/percentualAumento));
        }

         
    }
}