using System;
using System.Globalization;

namespace Triangulo_revisao{
    class Program{
        static void Main(string[] args){
            double xA, xB, xC, px, yA, yB, yC, py, areaX, areaY;

            Console.WriteLine("Medidas do triangulo X: ");
            System.Console.WriteLine("");

            System.Console.Write("Valor de xA: ");    
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.Write("Valor de xB: ");
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.Write("Valor de xC: ");
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            px = (xA + xB + xC) / 2;
            areaX = Math.Sqrt(px * (px - xA) * (px - xB) * (px - xC));

            Console.WriteLine("");

            System.Console.Write("Valor de yA: ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Valor de yB: ");
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Valor de yC: ");
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            py = (yA + yB + yC) / 2;
            areaY = Math.Sqrt(py * (py - yA) * (py - yB) * (py - yC));

            double maiorArea;

            Console.WriteLine("----------------------------");
            System.Console.WriteLine($"Area de X: {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            System.Console.WriteLine($"Area de Y: {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            if(areaX > areaY){
                maiorArea = areaX;

                Console.WriteLine("");
                System.Console.WriteLine($"Maior Area X: {maiorArea.ToString("F4", CultureInfo.InvariantCulture)}");
            }else{
                maiorArea = areaY;

                Console.WriteLine("");
                System.Console.WriteLine($"Maior Area Y: {maiorArea.ToString("F4", CultureInfo.InvariantCulture)}");
            }
            Console.WriteLine("----------------------------");

        }
    }
}
