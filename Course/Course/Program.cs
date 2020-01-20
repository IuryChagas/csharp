using System;
using System.Globalization;


namespace Course {
    class Program {
        static void Main(string[] args) {
           var name = "Sicrano Fuliveira";
           var saldo = 17.321547;
           var age = 31;
           
            Console.WriteLine("Nome: "+ name);
            Console.WriteLine("Saldo: $"+ saldo.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine(name +" tem "+ age +" anos, seu saldo atual é de R$"+ saldo.ToString("f3", CultureInfo.InvariantCulture)+ " reais");

            // Placeholder!
            Console.WriteLine("{0} tem {1} anos, seu saldo atual é de R${2:F2} reais", name, age, saldo);

            // Interpolação!
            Console.WriteLine($"{name} tem {age} anos, seu saldo atual é de R${saldo:F2} reais");
            Console.WriteLine($"{name} tem {age} anos, seu saldo atual é de R${saldo.ToString("F3", CultureInfo.InvariantCulture)} reais");
        }
    }
}
