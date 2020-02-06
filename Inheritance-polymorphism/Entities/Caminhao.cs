using System;
using static System.Console;

namespace Inheritance_polymorphism.Entities {
    class Caminhao : Veiculo {
        protected Caminhao(string marca, string modelo, string placa, string cor) : base(marca, modelo, placa, cor) {
            
        }
        public override void Acelerar() {
            if (IsLigado) {
                if (LitrosCombustivel >= 1) {
                    Velocidade += 20;
                    LitrosCombustivel -= 1;
                    WriteLine("Caminhão em movimento...\nVelocidade atual: " + Velocidade + " km/h");
                    WriteLine("Combustivel atual: " + LitrosCombustivel);
                } else {
                    WriteLine("Combustivel insuficiente!\n Abasteça!");
                };
            } else {
                WriteLine("Caminhão desligado, acione a chave! ");
            };
        }
        public void Abastecer(float abastecer) {
            if (abastecer + LitrosCombustivel <= 100) {
                if (!IsLigado) {
                    LitrosCombustivel += (int)abastecer;
                    WriteLine("Caminhão abastecido com sucesso!");
                } else {
                    WriteLine("Desligue veiculo antes de abastecer!");
                }
            } else {
                WriteLine($"Acima da capacidade permitida!\nCapacidade maxima: {100.0} Litros\nCombustivel atual: {LitrosCombustivel} Litros");
            }
        }
    }
}
