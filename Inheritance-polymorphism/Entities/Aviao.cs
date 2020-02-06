using System;
using static System.Console;

namespace Inheritance_polymorphism.Entities {
    class Aviao : Veiculo {
        protected Aviao(string marca, string modelo, string placa, string cor) : base(marca, modelo, placa, cor) {
            
        }
        public override void Acelerar() {
            if (IsLigado) {
                if (LitrosCombustivel >= 1) {
                    Velocidade += 20;
                    LitrosCombustivel -= 1;
                    WriteLine("Avião em movimento...\nVelocidade atual: " + Velocidade + " km/h");
                    WriteLine("Combustivel atual: " + LitrosCombustivel);
                } else {
                    WriteLine("Combustivel insuficiente!\n Abasteça!");
                };
            } else {
                WriteLine("Avião desligado, acione a chave! ");
            };
        }
        public void Abastecer(string abastecer) {
            if ( Convert.ToInt32(abastecer) + LitrosCombustivel <= 100) {
                if (!IsLigado) {
                    LitrosCombustivel += Convert.ToInt32(abastecer);
                    WriteLine("Avião abastecido com sucesso!");
                } else {
                    WriteLine("Desligue veiculo antes de abastecer!");
                }
            } else {
                WriteLine($"Acima da capacidade permitida!\nCapacidade maxima: {100} Litros\nCombustivel atual: {LitrosCombustivel} Litros");
            }
        }
    }
}
