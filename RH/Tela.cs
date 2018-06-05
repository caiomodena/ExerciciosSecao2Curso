using System;
using System.Globalization;

namespace RH
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Digite os dados do funcionários-----");
            Console.Write("Nome: ");
            String nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            double salarioBruto = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Desconto: ");
            double desconto = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Funcionario func = new Funcionario(nome,salarioBruto,desconto);

            Console.WriteLine("Dados do funcionário: {0}, R${1}.",func.nome,func.salarioLiquido().ToString("F2",CultureInfo.InvariantCulture));

            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            double porcentagem = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            func.aumentarSalario(porcentagem);

            Console.WriteLine("Dados do funcionário: {0}, R${1}.",func.nome,func.salarioLiquido().ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
