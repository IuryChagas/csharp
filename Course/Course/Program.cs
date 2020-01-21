using System;
using System.Globalization;
namespace Course {
    class Program {
        static void Main(string[] args) {
            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            Console.Write("Digite o valor do lado xA: ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o valor do lado xB: ");
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o valor do lado xC: ");
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            Console.Write("Digite o valor do lado yA: ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o valor do lado yB: ");
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite o valor do lado yC: ");
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

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
