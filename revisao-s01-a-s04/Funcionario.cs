using System;
using System.Globalization;

namespace revisao_s01_a_s04 {
    public class Funcionario {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido(){
            return Salario - Imposto;
        }
        public void AumentarSalario(double porcent){
            Salario = Salario + (porcent * Salario / 100.0);
        }

        override public string ToString(){
            return Nome
            + ", "
            + "U$ "
            + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}