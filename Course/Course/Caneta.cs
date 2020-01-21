using System;
using System.Globalization;

namespace Course {
    class Caneta {
        public string Modelo;
        public string Cor;
        public double Ponta;
        public int Carga;
        public bool Tampa;

        public void status() {
            Console.WriteLine($"### Caneta ### \nModelo: {this.Modelo} \nCor: {this.Cor} \nPonta: {this.Ponta.ToString("F1", CultureInfo.InvariantCulture)}");
            return;
        }
        void rabiscar() { 
            
        }

        void tampar() {
        
        }

        void destampar() {
            
        }
    }
}
