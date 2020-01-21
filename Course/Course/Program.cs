// Fazer um programa para ler os dados, nome e idade  de pessoas,
// Mostrar os dados da pessoa mais velha.

using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {
            Pessoa primeiroUsuario, segundoUsuario;

            primeiroUsuario = new Pessoa();
            segundoUsuario = new Pessoa();

            Console.Write("Digite o nome do(a) 1° usuário(a): ");
            primeiroUsuario.Name = Console.ReadLine();
            Console.Write("Digite a idade do(a) 1° usuário(a): ");
            primeiroUsuario.Age = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do(a) 2° usuário(a): ");
            segundoUsuario.Name = Console.ReadLine();
            Console.Write("Digite a idade do(a) 2° usuário(a): ");
            segundoUsuario.Age = int.Parse(Console.ReadLine());

            if (primeiroUsuario.Age > segundoUsuario.Age) {
                Console.WriteLine();
                Console.WriteLine("### Cadastro com maior idade ###");
                Console.WriteLine("");

                Console.WriteLine($"Nome: {primeiroUsuario.Name}");
                Console.WriteLine($"Idade: {primeiroUsuario.Age}");
            }
            else if (segundoUsuario.Age > primeiroUsuario.Age) {
                Console.WriteLine();
                Console.WriteLine("### Cadastro com maior idade ###");
                Console.WriteLine("");

                Console.WriteLine($"Nome: {segundoUsuario.Name}");
                Console.WriteLine($"Idade: {segundoUsuario.Age}");
            }
            else if (segundoUsuario.Age == primeiroUsuario.Age) {
                Console.WriteLine();
                Console.WriteLine("### As pessoas cadastradas possuem mesma idade ###");
                Console.WriteLine("");
            }
            else {
                Console.WriteLine();
                Console.WriteLine("### As pessoas cadastradas possuem mesma idade ###");
                Console.WriteLine("");
            }
        }
    }
}
