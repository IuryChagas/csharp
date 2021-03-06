﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Course {
    class Produto {
        public int MyProperty { get; set; }

        public string Nome;
        public double Preco;
        public int Quantidade;


        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
                        
        }
        public double ValorTotalEmEstoque() {
            double totalEmEstoque = (double)Preco * Quantidade;
            return totalEmEstoque;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return Nome
                + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
