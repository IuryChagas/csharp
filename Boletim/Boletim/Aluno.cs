using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Boletim {
    class Aluno {
        public string Nome;
        public double PrimeiraNota, SegundaNota, TerceiraNota;

        public double MediaAnual() {
            double media = PrimeiraNota + SegundaNota + TerceiraNota;

            if (media >= 60.0) {
                Console.WriteLine("APROVADO!");
            }
            else {
                double faltam = 60.0 - media;
                Console.WriteLine("REPROVADO! ");
                Console.WriteLine($"FALTARAM {faltam.ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }

            return media;
        }
    }
}
