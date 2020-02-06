namespace Diagrama_de_classe_UML.Entities {
    public class Livro : Produto {
        string Autor { get; set; }
        string Tema { get; set; }
        int QtdPag { get; set; }
        Livro () { }
        Livro (string nome, double preco, int qtd, string autor, string tema, int qtdpag) : base () {
            Autor = autor;
            Tema = tema;
            QtdPag = qtdpag;

        }
        public override double CalculaImposto () {
            if(Tema != "educativo"){
                Preco = Preco * 1.1;
            }
            return Preco;
        }
    }
}