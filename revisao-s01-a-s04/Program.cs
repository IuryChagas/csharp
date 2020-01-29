using System;
using System.Globalization;

namespace revisao_s01_a_s04 {
    class Program {
        static void Main(string[] args){
            Funcionario funcionario = new Funcionario();

            System.Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            System.Console.Write("Salario Bruto: ");
            funcionario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine("Funcionário: "+ funcionario);

            System.Console.WriteLine();

            System.Console.Write("Digite a porcentagem para aumento: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);

            System.Console.WriteLine("Dados atualizados: "+funcionario);
        }            
    }
}
