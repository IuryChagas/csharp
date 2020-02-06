using System.Collections.Generic;

namespace Diagrama_de_classe_UML.Entities {
    public class Loja {
        string Nome { get; set; }
        string Cnpj { get; set; }
        List<Livro> Livros { get; set; }
        List<VideoGame> VideoGames { get; set; }

        Loja () { }
        Loja (string nome, string cnpj) : base () {
            Nome = nome;
            Cnpj = cnpj;
            Livros = new List<Livro> ();
            VideoGames = new List<VideoGame> ();
        }
        void ListaLivros () {
            if (true){
                foreach (Livro mostra in Livros) {
                    System.Console.WriteLine($"Livro: {Livros}");
                }
            }else{
                    System.Console.WriteLine("A loja não tem livros no seu estoque. ");
            }
        }
        void ListaVideoGames () {
            if (true){
                foreach (Livro mostra in Livros) {
                    System.Console.WriteLine($"Livro: {VideoGames}");
                }
            }else{
                    System.Console.WriteLine("A loja não tem video-games no seu estoque.");
            }

        }
        double CalculaPatrimonio () {
           
           return ;
        }
    }
}