using System;
using System.Globalization;


namespace Course {
    class Program {
        static void Main(string[] args) {
            String product1 = "Computador";
            String product2 = "Mesa de escritório";

            byte age = 30;
            int code = 5290;
            char gender = 'M';

            double price1 = 2100.00;
            double price2 = 650.50;
            double measure = 53.234567;

            Console.WriteLine("Produtos:");

            Console.WriteLine($"{product1}, cujo preço é $ {price1:F2}");
            Console.WriteLine($"{product2}, cujo preço é $ {price2:F2}");
            
            Console.WriteLine();

            Console.WriteLine($"Registro: {age} anos de idade, código {code} e gênero: {gender}");

            Console.WriteLine();

            Console.WriteLine($"Medida com oito casas decimais: {measure:F8}");
            Console.WriteLine($"Arredondando (três casas decimais): {measure.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
