using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            Console.Write("Digite o valor do lado xA: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o valor do lado xB: ");
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o valor do lado xC: ");
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            Console.Write("Digite o valor do lado yA: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o valor do lado yB: ");
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o valor do lado yC: ");
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("");

            Console.WriteLine("Área de X = "+ areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = "+ areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY) {
                Console.WriteLine("Maior Área: Triangulo X com " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            }
            else if (areaY > areaX) {
                Console.WriteLine("Maior Área: Triangulo Y com " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            }
            else if (areaY == areaX) {
                Console.WriteLine("");

                Console.WriteLine("As Áreas dos triangulos são iguais!");
                Console.WriteLine("");
            }
            else {
                Console.WriteLine("\nOperação inválida... \nRepita todo processo!");
            }
        }
    }
}
