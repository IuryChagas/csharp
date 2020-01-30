using System.Globalization;

namespace revisao_s01_a_s04 {
    public class Produto {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto () { }

        public Produto (string nome, double preco, int quantidade) {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public int Quantidade { 
            get { return _quantidade; } 
            set {}
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
        public double Preco {
            get { return _preco; }
        }
        public double ValorTotalEmEstoque () {
            return _quantidade * _preco;
        }
        public void AdicionarProdutos (int quantidade) {
            _quantidade += quantidade;
        }
        public void RemoverProdutos (int quantidade) {
            _quantidade -= quantidade;
        }
    }
}