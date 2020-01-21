// Fazer um programa para ler os dados, nome e salário de funcionários,
// Mostrar o salário médio.

using System;
using System.Collections.Generic;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {
            Caneta canetaPremium = new Caneta();
            canetaPremium.Modelo = "Mont Blanc";
            canetaPremium.Cor = "Preta";
            canetaPremium.Ponta = 0.5d;
            canetaPremium.Carga = 100;
            canetaPremium.Tampa = false;
            canetaPremium.status();
        }
    }
}
