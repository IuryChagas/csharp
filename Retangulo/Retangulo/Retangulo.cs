using System;
using System.Collections.Generic;
using System.Text;

namespace Retangulo {
    class Retangulo {
        public double Largura;
        public double Altura;

        public double Area() {
            double totalArea = Largura * Altura;
            return totalArea;
        }
        public double Perimetro() {
            double perimetro = 2 * (Largura + Altura);
            return perimetro;
        }
        public double Diagonal() {
            double diagonal = Math.Sqrt(Largura * Largura + Altura * Altura);
            return diagonal;
        }
    }
}
