// Fazer um programa para ler os dados, nome e salário de funcionários,
// Mostrar o salário médio.

using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {
           Funcionario funcionario1, funcionario2;

            funcionario1 = new Funcionario();
            funcionario2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            funcionario2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double mediaSalario = (funcionario1.Salario + funcionario2.Salario) / 2;

            Console.WriteLine("");
            Console.WriteLine($" ### Salário médio: {mediaSalario.ToString("F2", CultureInfo.InvariantCulture)}  ###");
            Console.WriteLine("");
        }
    }
}
