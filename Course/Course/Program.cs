using System;
using System.Collections.Generic;
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


            double areaX = x.Area();    
            double areaY = y.Area();

            Console.WriteLine("");

            Console.WriteLine($"Área de X: {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área de Y: {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            if (areaX > areaY) {
                Console.WriteLine("Maior área: X");
            }
            else {
                Console.WriteLine("Maior área: Y");
            }

            Console.WriteLine("");


        }
    }
}
