using System;
using System.Globalization;

namespace Constructions {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("### Cadastro de Produtos no Estoque ###");

            Console.WriteLine("");
            Console.WriteLine("Adicione as informações do produto: \n");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto produto0 = new Produto();

            Produto produto1 = new Produto();

            Produto produto2 = new Produto {
                Nome = "TV",
                Preco = 500.00,
                Quantidade = 20
            };

            Console.WriteLine("");

            Console.WriteLine($"Dados do produto: {produto}");

            Console.WriteLine("");
            Console.Write("Digite a quantidade de produtos a ser adicionados ao estoque: ");
            int quantt = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(quantt);

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
