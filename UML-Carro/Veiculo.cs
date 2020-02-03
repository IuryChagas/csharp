using static System.Console;

namespace UML_Carro {
    public class Veiculo {
        public string  Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public double Preco { get; set; }
        public bool IsLigado { get; set; }
        public int Velocidade { get; set; }
        public float Km { get; set; }
        public int LitrosCombustivel { get; set; }        
        public void Acelerar(){
            if(IsLigado){
                if(LitrosCombustivel >= 1){
                    Velocidade += 20;
                    LitrosCombustivel -= 1;
                    WriteLine("Carro na pista!\nVelocidade atual: "+Velocidade+" km/h");
                    WriteLine("Combustivel atual: "+LitrosCombustivel);
                }else{
                    WriteLine("Combustivel insuficiente!\n necessário [5]abastecer!");
                };
            }else{
                    WriteLine("Carro desligado, acione a chave! ");
                };
        }
        public void Abastecer(int abastecer){
            if(abastecer + LitrosCombustivel <= 100){
                if(!IsLigado){
                LitrosCombustivel += abastecer;
                WriteLine("Carro abastecido com sucesso!");
                }else{
                    WriteLine("Necessário desligar o carro antes de abastecer!");
                }
            }else{
                WriteLine("Acima da capacidade permitida!\nCombustivel atual "+LitrosCombustivel+" Litros");
            }
        }
        public void Frear() {
            if(IsLigado && Velocidade > 0){    
                Velocidade -= 10;
                WriteLine("Freios acionados!\nVelocidade atual: "+Velocidade+" km/h");
            }else{
                WriteLine("Carro já esta parado! ");
            }
        }
        public void Ligar(){
            if(IsLigado){
                WriteLine("Carro já esta ligado! ");
            }else{
                IsLigado = true;
                WriteLine("Carro ligado!");
            }
        }
        public void Desligar() {
            if(IsLigado){
                if(Velocidade == 0){
                    IsLigado = false;
                    WriteLine("Carro foi desligado!");
                } else{
                    WriteLine("Acione os freios!\nVelocidade atual "+Velocidade+" km/h");
                }
            }else{
                WriteLine("Carro já esta desligado!");
            }

        }
    }
}