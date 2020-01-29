using System;
using System.Globalization;

namespace revisao_s01_a_s04 {
    class Program {
        static void Main(string[] args){
            System.Console.Write("Qual a cotação do dolar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.Write("Quantos dolares à comprar: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversorDeMoeda.DolarParaReal(quantia, cotacao);

            System.Console.WriteLine("Valor a ser pago em reais: "+ resultado.ToString("F2", CultureInfo.InvariantCulture));
        }            
    }
}