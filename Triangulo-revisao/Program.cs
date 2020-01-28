using System;
using System.Globalization;

namespace Triangulo_revisao{
    class Program{
        static void Main(string[] args){
            
            double areaX, areaY, p;

            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Medidas do triangulo X: ");
            System.Console.WriteLine("");

            System.Console.Write("Valor de xA: ");    
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.Write("Valor de xB: ");
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.Write("Valor de xC: ");
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            areaX = x.Area();

            Console.WriteLine("");
            Console.WriteLine("Medidas do triangulo Y: ");
            Console.WriteLine("");

            System.Console.Write("Valor de yA: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Valor de yB: ");
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Valor de yC: ");
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            areaY = y.Area();

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
