using System.Globalization;

namespace revisao_s01_a_s04 {
    public class Produto {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto(){
        }

        public Produto (string nome, double preco, int quantidade){
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public int GetQuantidade (){
            return _quantidade;
        }
        public string GetNome (){
            return _nome;
        }

        public void SetNome (string nome){
            if(nome != null && nome.Length > 1){
                _nome = nome;
            }
            
        }
        public double GetPreco(){
            return _preco;
        }
        public double ValorTotalEmEstoque(){
            return _quantidade * _preco;
        }

        public void AdicionarProdutos( int quantidade) {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            _quantidade -= quantidade;
        }

        override public string ToString(){
            return _nome
            +", Valor U$"
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: U$"
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}