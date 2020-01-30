using System.Globalization;

namespace revisao_s01_a_s04 {
    public class Produto {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto (string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome {
            get { return _nome; }
            set { 
                if(value != null && value.Length > 1){
                    _nome = value;
                    System.Console.Write("Valor do atributo _nome alterado para: ");
                } else {
                    System.Console.Write("Valor do atributo _nome não alterado: ");
                }
            }
        }
        public double ValorTotalEmEstoque () {
            return Quantidade * Preco;
        }
        public void AdicionarProdutos (int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos (int quantidade) {
            Quantidade -= quantidade;
        }
    }
}