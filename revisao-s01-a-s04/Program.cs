using System;
using System.Globalization;

namespace revisao_s01_a_s04 {
    class Program {
        static void Main(string[] args){
            
            Produto product = new Produto ("Notebook", 500.00, 10);
                System.Console.WriteLine(product.Quantidade);
                
                System.Console.WriteLine(product.Preco.ToString("F2", CultureInfo.InvariantCulture));
                
                System.Console.Write("Setar um novo valor: ");
                product.Nome = Console.ReadLine();

                System.Console.WriteLine(""+product.Nome);
        }
    }
}