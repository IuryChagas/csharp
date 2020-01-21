using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {
            int soma = 0;

            Console.WriteLine("### DIGITE A QUANTIDADE DE NÚMEROS QUE QUER SOMAR ###");

            Console.Write("Quantos números inteiros quer somar: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            for (int i = 1; i <= y; i++){
                Console.Write(i +"° valor: ");
                int numero = int.Parse(Console.ReadLine());
                soma += numero;
            }
            
            Console.WriteLine("");

            Console.WriteLine("Soma total dos números digitados: "+ soma);
            
        }
    }
}
