namespace Diagrama_de_classe_UML.Entities {
    public abstract class Produto : Imposto {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Qtd { get; set; }

        public Produto () { }
        public Produto (string nome, double preco, int qtd) {
            Nome = nome;
            Preco = preco;
            Qtd = qtd;
        }
        public abstract double CalculaImposto();
    }
}