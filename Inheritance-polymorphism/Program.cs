using System;
using static System.Console;
using Inheritance_polymorphism.Entities;

namespace Inheritance_polymorphism {
    class Program {
        static void Main (string[] args) {
            Write ("Escolha um dos Veiculos: ");
            WriteLine ();
            WriteLine ("[1] Carro: ");
            WriteLine ("[2] Caminhão: ");
            WriteLine ("[3] Avião: ");
            Write ("  > ");
            int resp = int.Parse (Console.ReadLine ());

            if (resp == 1) {
                TestDrivCarro ();

            } else if (resp == 2) {
                // TestDriv(caminhao);
            } else {
                // TestDriv(aviao); 
            }

        }
        static void TestDrivCarro () {
            Carro carro = new Carro ();
            string marca, modelo, placa, cor;
            Clear ();

            WriteLine ("Veiculo: Carro");
            WriteLine ();
            WriteLine (" ## ESCOLHA MARCA ## ");
            WriteLine ();
            WriteLine ("[1] Aston Martin: ");
            WriteLine ("[2] Rolls-Royce: ");
            WriteLine ("[3] Porsche: ");
            Write ("  > ");
            int optmarca = int.Parse (Console.ReadLine ());

            switch (optmarca) {
                case 1:
                    marca = "Aston Martin";
                    Clear ();
                    WriteLine ("Veiculo: Carro");
                    WriteLine ($"Marca selecionada: {marca}");
                    WriteLine ();
                    modelo = Modelo1 ();
                    break;
                case 2:
                    marca = "Rolls-Royce";
                    Clear ();
                    WriteLine ("Veiculo: Carro");
                    WriteLine ($"Marca selecionada: {marca}");
                    WriteLine ();
                    modelo = Modelo2 ();
                    break;
                case 3:
                    marca = "Porsche";
                    Clear ();
                    WriteLine ("Veiculo selecionado: Carro");
                    WriteLine ($"Marca selecionada: {marca}");
                    WriteLine ();
                    modelo = Modelo3 ();
                    break;
                default:
                    WriteLine ("Opção inválida!");
                    break;
            }
            WriteLine ();
            WriteLine (" ## CUSTOMIZAR PLACA ## ");
            WriteLine ();
            Write ("> Escolha 3 Letras de A á Z: ");
            string LetrasDaPlaca = Console.ReadLine ().ToUpper ();

            Write ("> Escolha 4 Números entre 0 à 9: ");
            int NumerosDaPlaca = int.Parse (Console.ReadLine ());
            placa = LetrasDaPlaca + "-" + NumerosDaPlaca.ToString ();

            WriteLine ();
            WriteLine (" ## ESCOLHA COR ## ");
            WriteLine ();
            WriteLine ("[1] Preto: ");
            WriteLine ("[2] Cinza: ");
            Write ("  > ");
            cor = Cor ();

            WriteLine();
            WriteLine($"Veiculo: Carro");
            WriteLine($"Veiculo: {carro.Modelo}");
            WriteLine($"Veiculo: {carro.Cor}");
            WriteLine($"Veiculo: {carro.Placa}");
            WriteLine();

            var continuar = true;

            while(continuar){
                WriteLine ();
                WriteLine ("[1] Ligar: ");
                WriteLine ("[2] Acelerar: ");
                WriteLine ("[3] Frear: ");
                WriteLine ("[4] Desligar: ");
                WriteLine ("[5] Abastecer: ");
                Write (" Qualquer tecla para sair: ");
                int choice;
                choice = int.Parse (Console.ReadLine ());

                switch (choice) {
                    case 1:
                        carro.Ligar ();
                        break;
                    case 2:
                        carro.Acelerar ();
                        break;
                    case 3:
                        carro.Reduzir ();
                        break;
                    case 4:
                        carro.Desligar ();
                        break;
                    case 5:
                        Write ("Quantos deseja Abastecer [max. 100L]: ");
                        int abastecer = int.Parse (Console.ReadLine ());
                        carro.Abastecer (abastecer);
                        break;
                    default:
                        System.Console.WriteLine ("Fechando!!");
                        continuar = false;
                        break;
                }
            }
        }

        private static string Modelo1 () {
            WriteLine (" ## ESCOLHA MODELO ## ");
            WriteLine ();
            WriteLine ("[1] Vanquish S: ");
            WriteLine ("[2] Rapide S: ");
            Write ("  > ");
            int optmodelo1 = int.Parse (Console.ReadLine ());
            switch (optmodelo1) {
                case 1:
                    return "Vanquish S";
                case 2:
                    return "Rapide S";
                default:
                    WriteLine ("Opção inválida!");
                    return Modelo1 ();
            }
        }
        private static string Modelo2 () {
            WriteLine (" ## ESCOLHA MODELO ## ");
            WriteLine ();
            WriteLine ("[1] Silver Ghost: ");
            WriteLine ("[2] Phantom III: ");
            Write ("  > ");
            int optmodelo2 = int.Parse (Console.ReadLine ());

            switch (optmodelo2) {
                case 1:
                    return "Silver Ghost";
                case 2:
                    return "Phantom III";
                default:
                    WriteLine ("Opção inválida!");
                    return Modelo2 ();
            }
        }
        private static string Modelo3 () {
            WriteLine (" ## ESCOLHA MODELO ## ");
            WriteLine ();
            WriteLine ("[1] Porsche 356: ");
            WriteLine ("[2] RS 60 SPYDER: ");
            Write ("  > ");
            int optmodelo3 = int.Parse (Console.ReadLine ());

            switch (optmodelo3) {
                case 1:
                    return "Porsche 356";
                case 2:
                    return "RS 60 SPYDER";
                case 3:
                default:
                    WriteLine ("Opção inválida!");
                    return Modelo3 ();
            }
        }
        private static string Cor () {
            int optcor = int.Parse (Console.ReadLine ());

            switch (optcor) {
                case 1:
                    return "Preto";
                case 2:
                    return "Cinza";
                default:
                    WriteLine ("Opção inválida!");
                    return Cor ();
            }
        }
    }
}