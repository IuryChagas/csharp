namespace Diagrama_de_classe_UML.Entities {
    public class VideoGame : Produto {
        string Marca { get; set; }
        string Modelo { get; set; }
        bool IsUsado { get; set; }

        VideoGame () { }
        VideoGame (string nome, double preco, int qtd, string marca, string modelo, bool isusado) : base () {
            Marca = marca;
            Modelo = modelo;
            IsUsado = isusado;
        }

        public override double CalculaImposto () {
            if(IsUsado){
                Preco = Preco * 1.25;
            }else{
                Preco = Preco * 1.45;
            }
            return Preco;
        }
    }
}