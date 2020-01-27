using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Properties {
    class Produto {

        private string _nome;
        public double Preco {get ; private set; }
        public int Quantidade { get; private set; }
        

        public Produto(string nome, double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;

        }

        public string Nome {
            get { return _nome; }
            set { if (value != null && value.Length > 1) {
                    _nome = value;        
                } 
            }
        }


        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;

        }
        public double ValorTotalEmEstoque() {
            double totalEmEstoque = (double) Preco * Quantidade;
            return totalEmEstoque;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return _nome
                + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}