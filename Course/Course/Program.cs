using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("### Cadastro de Produtos no Estoque ###");

            Produto produto = new Produto();

            Console.WriteLine("");
            Console.WriteLine("Adicione as informações do produto: \n");
            
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"Dados do produto: {produto}");

            Console.WriteLine("");
            Console.Write("Digite a quantidade de produtos a ser adicionados ao estoque: ");
            int quantidade = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(quantidade);

            Console.WriteLine("");
            Console.WriteLine($"Dados atualizados: {produto}");

            Console.WriteLine("");
            Console.Write("Digite a quantidade de produtos a ser removido do estoque: ");
            int removeQuantidade = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(removeQuantidade);

            Console.WriteLine("");
            Console.WriteLine($"Dados atualizados: {produto}");
        }
    }
}
