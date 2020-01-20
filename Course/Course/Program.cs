using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite seu nome completo: ");
             string name = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem sua casa: ");
             int bedroom = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
             double product = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite seu último nome, idade e altura (tudo na mesma linha com espaços entre): ");
            string[] vet = Console.ReadLine().Split(' ');

            string nome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(" ");

            Console.WriteLine(name);
            Console.WriteLine(bedroom);
            Console.WriteLine(product.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(idade.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));




        }
    }
}
