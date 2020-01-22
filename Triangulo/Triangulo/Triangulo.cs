using System;

namespace Triangulo {
    class Triangulo {
        public static double Pi = 3.14;
        public static double Circunferencia(double x) {

            return 2.0 * Pi * x;
        }
        public static double Volume(double x) {

            return 4.0 / 3.0 * Pi * Math.Pow(x, 3.0);
        }
    }
}
