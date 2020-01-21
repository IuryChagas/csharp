// Fazer um programa para ler os dados, nome e idade  de pessoas,
// Mostrar os dados da pessoa mais velha.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Course {
    class Program {
        static void Main(string[] args) {

            List<Pessoa> pessoas = new List<Pessoa>();

            Console.Write("Quantas pessoas você quer cadastrar? ");
            int numeroDeCadastros = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeroDeCadastros; i++) {
                Pessoa user = new Pessoa();

                Console.WriteLine($"Digite os dados da {i+1}° pessoa: ");
                Console.Write("Nome: ");
                user.Name = Console.ReadLine();
                Console.Write("Idade: ");
                user.Age = int.Parse(Console.ReadLine());

                pessoas.Add(user);
            }

            var pessoaMaisVelha = pessoas.OrderBy(p => p.Age).LastOrDefault();

            Console.WriteLine("### Cadastro com maior idade ###");
            Console.WriteLine("");

            Console.WriteLine($"Nome: {pessoaMaisVelha.Name}");
            Console.WriteLine($"Idade: {pessoaMaisVelha.Age}");


        }
    }
}
