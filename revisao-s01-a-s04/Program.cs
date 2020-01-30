using System;
using System.Globalization;

namespace revisao_s01_a_s04 {
    class Program {
        static void Main(string[] args){
            
            Produto product = new Produto ("Notebook", 500.00, 10);
                System.Console.WriteLine(product.GetQuantidade());
                
                System.Console.WriteLine(product.GetPreco().ToString("F2", CultureInfo.InvariantCulture));
                
                System.Console.Write("Setar um novo valor: ");
                string nome = Console.ReadLine();
                product.SetNome(nome);
               
                System.Console.Write("Valor do atributo _nome alterado para: "+product.GetNome());

        }
    }
}