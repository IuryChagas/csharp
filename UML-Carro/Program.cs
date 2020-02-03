using System;
using System.Collections.Generic;
using static System.Console;

namespace UML_Carro {
    class Program {
        static void Main (string[] args) {
            Veiculo carro = new Veiculo ();

            CostumizarCarro ();
            WriteLine (" #### Iniciando TestDrive! ###");
            TestDriver(carro);
        }
        static void TestDriver (Veiculo veiculo) {
            int choice;

            WriteLine ();
            WriteLine ("[1] Ligar: ");
            WriteLine ("[2] Acelerar: ");
            WriteLine ("[3] Frear: ");
            WriteLine ("[4] Desligar: ");
            WriteLine ("[5] Abastecer: ");

            choice = int.Parse (Console.ReadLine ());
            switch (choice) {
                case 1:
                    veiculo.Ligar();
                break;
                case 2:
                    veiculo.Acelerar();
                break;
                case 3:
                    veiculo.Frear();
                break;
                case 4:
                    veiculo.Desligar();
                break;
                case 5:
                    Write("Quantos deseja Abastecer: ");
                    int abastecer = int.Parse(Console.ReadLine());
                    veiculo.Abastecer(abastecer);
                break;
                default:
                    System.Console.WriteLine("Opção inválida!");
                    TestDriver (veiculo);
                break;
            }
            TestDriver (veiculo);

        }
        static void CostumizarCarro () {
            Veiculo veiculo = new Veiculo ();

            WriteLine ();
            WriteLine (" ## CUSTOMIZANDO CARRO ## ");
            WriteLine ();
            WriteLine ("[1] Audi: ");
            WriteLine ("[2] BMW: ");
            WriteLine ("[3] Lamborghini: ");
            WriteLine ("[4] Ferrari: ");
            WriteLine ("[5] Aston Martin: ");
            WriteLine ("[6] Rolls-Royce: ");
            WriteLine ("[7] Porsche: ");
            WriteLine ();
            Write ("> Escolha uma marca: ");
            int caseSwitch = int.Parse (ReadLine ());

            List<Modelo> ListaModelos = new List<Modelo> () { };

            ListaModelos.AddRange (
                new List<Modelo> () {
                    new Modelo ("Audi", "A5", "A7"),
                        new Modelo ("BMW", "X4", "X5"),
                        new Modelo ("Lamborghini", "Jota", "Veneno"),
                        new Modelo ("Ferrari", "308 GTS", "Dino 246 GTS"),
                        new Modelo ("AstonMartin", "Vanquish S", "Rapide S"),
                        new Modelo ("RollsRoyce", "Silver Ghost", "Phantom III"),
                        new Modelo ("Porsche", "Porsche 356", "RS 60 SPYDER")
                }
            );

            switch (caseSwitch) {

                case 1:
                    CustomizarModelo (veiculo, ListaModelos[0]);
                    break;
                case 2:
                    CustomizarModelo (veiculo, ListaModelos[1]);
                    break;
                case 3:
                    CustomizarModelo (veiculo, ListaModelos[2]);
                    break;
                case 4:
                    CustomizarModelo (veiculo, ListaModelos[3]);
                    break;
                case 5:
                    CustomizarModelo (veiculo, ListaModelos[4]);
                    break;
                case 6:
                    CustomizarModelo (veiculo, ListaModelos[5]);
                    break;
                case 7:
                    CustomizarModelo (veiculo, ListaModelos[6]);
                    break;
                default:
                    WriteLine ("Opção inválida!");
                    break;
            }
        }
        static void CustomizarModelo (Veiculo veiculo, Modelo modelo) {
            int escolha = 0;

            veiculo.Marca = modelo.Marca;
            Write ($"[1] {modelo.Modelo1}:\n[2] {modelo.Modelo2}:\n> Escolha um dos modelos: ");
            escolha = int.Parse (Console.ReadLine ());

            if (escolha == 1) {
                veiculo.Modelo = modelo.Modelo1;
            } else if (escolha == 2) {
                veiculo.Modelo = modelo.Modelo2;
            } else {
                WriteLine ("> Opção inválida! ");
            }
            Clear ();
            WriteLine ($"Marca: {veiculo.Marca}");
            WriteLine ($"Modelo: {veiculo.Modelo}");

            CustomizarPlaca (veiculo);
            CustomizarCor (veiculo);
        }
        static void CustomizarPlaca (Veiculo veiculo) {
            System.Console.WriteLine ();

            WriteLine ("## CUSTOMIZANDO PLACA ## ");
            Write ("> Escolha 3 Letras de A á Z: ");
            string LetrasDaPlaca = Console.ReadLine ().ToUpper ();

            Write ("> Escolha 4 Números entre 0 à 9: ");
            int NumerosDaPlaca = int.Parse (Console.ReadLine ());

            veiculo.Placa = LetrasDaPlaca + "-" + NumerosDaPlaca.ToString ();
            Clear ();
            WriteLine ($"Marca: {veiculo.Marca}");
            WriteLine ($"Modelo: {veiculo.Modelo}");
            WriteLine ($"Placa: {veiculo.Placa}");
        }
        static void CustomizarCor (Veiculo veiculo) {
            WriteLine ("## CUSTOMIZANDO COR ## ");
            WriteLine ();
            WriteLine ("[1] Azul: ");
            WriteLine ("[2] Preto: ");
            WriteLine ("[3] Cinza: ");
            WriteLine ("[4] Vermelho: ");
            WriteLine ("[5] Roxo: ");
            WriteLine ("[6] Marrom: ");
            WriteLine ("[7] Branco: ");
            Write ("> Escolha uma das cores: ");
            int caseSwitch = int.Parse (ReadLine ());

            switch (caseSwitch) {

                case 1:
                    veiculo.Cor = "Azul";
                    break;
                case 2:
                    veiculo.Cor = "Preto";
                    break;
                case 3:
                    veiculo.Cor = "Cinza";
                    break;
                case 4:
                    veiculo.Cor = "Vermelho";
                    break;
                case 5:
                    veiculo.Cor = "Roxo";
                    break;
                case 6:
                    veiculo.Cor = "Marrom";
                    break;
                case 7:
                    veiculo.Cor = "Branco";
                    break;
                default:
                    WriteLine ("Opção inválida!");
                    break;
            }
            Clear ();
            WriteLine ($"Marca: {veiculo.Marca}");
            WriteLine ($"Modelo: {veiculo.Modelo}");
            WriteLine ($"Placa: {veiculo.Placa}");
            WriteLine ($"Cor: {veiculo.Cor}");

        }

    }
}