using System;

namespace Diagrama_de_classe_UML {
    class Program{
        static void Main (string[] args) {
            Livro l1 = new Livro("H. Potter", 40, 50, "J. K. Rowling", "fantasia", 300);
            Livro l2 = new Livro("Lord of the rings", 60, 30, "J. R.R Tolkien", "fantasia", 500);
            Livro l3 = new Livro("Java POO", 20, 50, "GFT", "educativo", 500);

            VideoGame ps4 = new VideoGame("PS4", 1800, 100, "Sony", "Slim", false);
            VideoGame ps4Usado = new VideoGame("PS4", 1000, 7, "Sony", "Slim", true);
            VideoGame xbox = new VideoGame("XBOX", 1500, 500, "Microsoft", "One", false);

            List<Livros> livros = new ArrayList<>();
            livros.add(l1);
            livros.add(l2);
            livros.add(l3);

            List<VideoGames> games = new ArrayList<>();
            games.Add(ps4);
            games.Add(ps4Usado);
            games.Add(xbox);

            Loja americanas = new Loja("Americanas", "12345678", livros, games);

            l2.calculadoraImposto();
            l3.calculadoraImposto();

            ps4Usado.calculadoraImposto();
            ps4.calculadoraImposto();

            americanas.listaLivros();
            americanas.listaVideoGames();
            americanas.calculaPatrimonio();
        }
    }
}