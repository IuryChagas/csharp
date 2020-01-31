namespace UML_Carro {
    public class Veiculo {
        public string  Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public float Km { get; set; }
        public bool IsLigado { get; set; }
        public int LitrosCombustivel { get; set; }
        public int Velocidade { get; set; }
        public double Preco { get; set; }

        
        public int Acelerar(){
            return 0;
        }
        public double Abastecer(){
            return 0;
        }
        public string Frear() {
            return null;
        }
        public string Pintar(){
            return null;
        }

        public string Ligar(){
            return null;
        }
        public string Desligar() {
            return null;
        }
    }
}