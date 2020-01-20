using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite três números na mesma linha separados por um espaço: ");
            string[] vet = Console.ReadLine().Split(' ');

            int n1 = int.Parse(vet[0]);
            int n2 = int.Parse(vet[1]);
            int n3 = int.Parse(vet[2]);

            double resultado = MaiorNumero(n1, n2, n3);
            Console.WriteLine("O Maior número é: "+ resultado);
        }

        static int MaiorNumero(int a, int b, int c) {
            int maiorDeTodos;

            if (a > b && a > c) {
                maiorDeTodos  = a;
            }
            else if (b > c) {
                maiorDeTodos = b;
            }
            else {
                maiorDeTodos = c;
            }
            return maiorDeTodos;
        }
    }
}
