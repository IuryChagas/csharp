using System;
using System.Globalization;

namespace revisao_s01_a_s04 {
    class Program {
        static void Main(string[] args){
            
            System.Console.Write("Nome: ");
            string nome = Console.ReadLine();

            System.Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nome, preco, quantidade);

            System.Console.WriteLine($"Dados do Produto: {produto}");
            System.Console.WriteLine();


            System.Console.Write("Digite o n° de produtos à ser adicionados ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qtd);

            System.Console.WriteLine();
            System.Console.WriteLine($"Dados atualizados: {produto}");

            System.Console.WriteLine();

            System.Console.Write("Digite o n° de produtos à ser removidos do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qtd);

            System.Console.WriteLine();
            System.Console.WriteLine($"Dados atualizados: {produto}");

        }            
    }
}