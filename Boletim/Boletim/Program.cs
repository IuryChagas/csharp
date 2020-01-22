using System;
using System.Globalization;

namespace Boletim {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("    #### BOLETIM ESCOLAR ####");
            Console.WriteLine("");

            Aluno aluno = new Aluno();
            
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("1° nota: ");
            aluno.PrimeiraNota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("2° nota: ");
            aluno.SegundaNota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("3° nota: ");
            aluno.TerceiraNota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");


            Console.WriteLine("NOTA FINAL = "+ aluno.MediaAnual().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
