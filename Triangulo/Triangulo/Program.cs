using System;
using System.Globalization;

namespace Triangulo {
    class Program {
        static void Main(string[] args) {
 
            Console.Write("Entre com o valor de raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");
            double circ = Triangulo.Circunferencia(raio);
            Console.WriteLine($"Circunferência: {circ.ToString("F2", CultureInfo.InvariantCulture)}");

            double vol = Triangulo.Volume(raio);
            Console.WriteLine($"Volume: {vol.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine($"Valor de PI: {Triangulo.Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        
  
    }
}
