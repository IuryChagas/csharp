using System.Globalization;

namespace revisao_s01_a_s04 {
    public class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto (string nome, double preco, int quantidade){
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public double ValorTotalEmEstoque(){
            return Quantidade * Preco;
        }

        public void AdicionarProdutos( int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        override public string ToString(){
            return Nome
            +", Valor U$"
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: U$"
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}