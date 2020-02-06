using System;
using static System.Console;

namespace Inheritance_polymorphism.Entities {
    class Carro : Veiculo {

        public Carro (string marca, string modelo, string placa, string cor) : base (marca, modelo, placa, cor) {
        }

        public Carro () :base() {
            
        }

        public override void Acelerar () {
            if (IsLigado) {
                if (LitrosCombustivel >= 1) {
                    Velocidade += 20;
                    LitrosCombustivel -= 1;
                    WriteLine ("Carro em movimento...\nVelocidade atual: " + Velocidade + " km/h");
                    WriteLine ("Combustivel atual: " + LitrosCombustivel);
                } else {
                    WriteLine ("Combustivel insuficiente!\n Abasteça!");
                };
            } else {
                WriteLine ("Carro desligado, acione a chave! ");
            };
        }

        public override void Abastecer (int abastecer) {
            if (abastecer + LitrosCombustivel <= 100) {
                if (!IsLigado) {
                    LitrosCombustivel += abastecer;
                    WriteLine ("Carro abastecido com sucesso!");
                } else {
                    WriteLine ("Desligue veiculo antes de abastecer!");
                }
            } else {
                WriteLine ($"Acima da capacidade permitida!\nCapacidade maxima: {100} Litros\nCombustivel atual: {LitrosCombustivel} Litros");
            }
        }

        public override void Reduzir () {
            if (IsLigado && Velocidade > 0) {
                Velocidade -= 10;
                WriteLine ($"Reduzindo velocidade!\nVelocidade atual: {Velocidade} km/h");
            } else {
                WriteLine ("Carro já esta parado! ");
            }
        }

        public override void Ligar () {
            if (IsLigado) {
                WriteLine ("Carro já esta ligado! ");
            } else {
                IsLigado = true;
                WriteLine ("Carro ligado!");
            }
        }

        public override void Desligar () {
            if (IsLigado) {
                if (Velocidade == 0) {
                    IsLigado = false;
                    WriteLine ("Carro desligado!");
                } else {
                    WriteLine ("Reduza velocidade!\nVelocidade atual " + Velocidade + " km/h");
                }
            } else {
                WriteLine ("Carro já esta desligado!");
            }

        }
    }
}