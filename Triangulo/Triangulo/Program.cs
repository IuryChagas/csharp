using System;
using System.Globalization;

namespace Triangulo {
    class Program {
        static double Pi = 3.14;
        static void Main(string[] args) {
           
            Console.Write("Entre com o valor de raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            Console.WriteLine($"Circunferência: {circ.ToString("F2", CultureInfo.InvariantCulture)}");

            double vol = Volume(raio);
            Console.WriteLine($"Volume: {vol.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine($"Valor de PI: {Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        static double Circunferencia(double x) {

            return 2.0 * Pi * x;
        }
        static double Volume(double x) {

            return 4.0 / 3.0 * Pi * Math.Pow(x, 3.0);
        }
  
    }
}
