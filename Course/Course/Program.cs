using System;
using System.Globalization;


namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite: ");
            String frase = Console.ReadLine();

            String x = Console.ReadLine();
            String y = Console.ReadLine();
            String z = Console.ReadLine();

            String[] vet = Console.ReadLine().Split(' ');
            String a = vet[0];
            String b = vet[1];
            String c = vet[2];

            Console.WriteLine(" ");
            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine(vet[0]);
            Console.WriteLine(vet[1]);
            Console.WriteLine(vet[2]);
        }
    }
}
