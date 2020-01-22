using System;
using System.Globalization;

namespace Formulario {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("         ### FORMULÁRIO PARA CADASTRAR FUNCIONÁRIO ###");

            Funcionario funcionario = new Funcionario();
            
            Console.Write("NOME: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("SALÁRIO BRUTO: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("IMPOSTO: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");
            Console.WriteLine($"Funcionário: {funcionario}");

            Console.WriteLine("");
            Console.Write($"Digite a porcentagem para aumentar o salário [00.0 à 100.0]: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);

            Console.WriteLine("");
            Console.WriteLine($"Dados atualizados: {funcionario}");
        }
    }
}
