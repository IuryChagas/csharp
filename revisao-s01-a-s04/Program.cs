using System;
using System.Globalization;

namespace revisao_s01_a_s04 {
    class Program {
        static void Main(string[] args){
            Produto produto = new Produto();

            System.Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();

            System.Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

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
