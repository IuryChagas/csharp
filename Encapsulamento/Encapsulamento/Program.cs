using System;
using System.Globalization;

namespace Encapsulamento {
    class Program {
        static void Main(string[] args) {
            Produto produto = new Produto("TV", 500.00, 10);
            Console.WriteLine("Nome: "+ produto.Nome);

            produto.Nome = ("TV 4k");
            Console.WriteLine("\n");

            Console.WriteLine($"Novo nome: {produto.Nome}");       
            Console.WriteLine($"Preço: {produto.Preco}");
            Console.WriteLine($"Quantidade: {produto.Quantidade}");
        }
    }
}