using System;
using static System.Console;

namespace Inheritance_polymorphism.Entities {
    class Veiculo {
        public string Marca { get; protected set; }
        public string Modelo { get; protected set; }
        public string Placa { get; protected set; }
        public string Cor { get; protected set; }
        public double Preco { get; protected set; }
        public bool IsLigado { get; protected set; }
        public int Velocidade { get; protected set; }
        public float Km { get; protected set; }
        public int LitrosCombustivel { get; protected set; }

        public Veiculo(){
            IsLigado = false;
            Velocidade = 0;
            LitrosCombustivel = 0;
          }
        public Veiculo(string marca, string modelo, string placa, string cor) {
            Marca = marca;
            Modelo = modelo;
            Placa = placa;
            Cor = cor;
            IsLigado = false;
            // por padrão é zero!
            //Velocidade = 0; 
            //LitrosCombustivel = 0;
        }
        public virtual void Acelerar() {
            if (IsLigado) {
                if (LitrosCombustivel >= 1) {
                    Velocidade += 20;
                    LitrosCombustivel -= 1;
                    WriteLine("Veiculo em movimento...\nVelocidade atual: " + Velocidade + " km/h");
                    WriteLine("Combustivel atual: " + LitrosCombustivel);
                } else {
                    WriteLine("Combustivel insuficiente!\n Abasteça!");
                };
            } else {
                WriteLine("Veiculo desligado, acione a chave! ");
            };
        }

        public virtual void Abastecer(int abastecer) {
            if (abastecer + LitrosCombustivel <= 100) {
                if (!IsLigado) {
                    LitrosCombustivel += abastecer;
                    WriteLine("Veiculo abastecido com sucesso!");
                } else {
                    WriteLine("Desligue veiculo antes de abastecer!");
                }
            } else {
                WriteLine($"Acima da capacidade permitida!\nCapacidade maxima: {100} Litros\nCombustivel atual: {LitrosCombustivel} Litros");
            }
        }

        public virtual void Reduzir() {
            if (IsLigado && Velocidade > 0) {
                Velocidade -= 10;
                WriteLine($"Reduzindo velocidade!\nVelocidade atual: {Velocidade} km/h");
            } else {
                WriteLine("Veiculo já esta parado! ");
            }
        }

        public virtual void Ligar() {
            if (IsLigado) {
                WriteLine("Veiculo já esta ligado! ");
            } else {
                IsLigado = true;
                WriteLine("Veiculo ligado!");
            }
        }

        public virtual void Desligar() {
            if (IsLigado) {
                if (Velocidade == 0) {
                    IsLigado = false;
                    WriteLine("Veiculo desligado!");
                } else {
                    WriteLine("Reduza velocidade!\nVelocidade atual " + Velocidade + " km/h");
                }
            } else {
                WriteLine("Veiculo já esta desligado!");
            }

        }
    }
}
