using System;
using System.Globalization;

namespace Retangulo {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("          ######### DIGITE A LARGURA E ALTURA DO RETANGULO #########");

            Retangulo retangulo = new Retangulo();

            Console.Write("Largura: ");
            retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Altura: ");
            retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine($"ÁREA: {retangulo.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERÍMETRO: {retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL: {retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
