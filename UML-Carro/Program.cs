using System;
using System.Collections.Generic;
using static System.Console;

namespace UML_Carro {
    class Program {
        static void Main (string[] args) {
            CostumizarCarro ();
        }
        static void CostumizarCarro () {
            Veiculo veiculo = new Veiculo ();
            
            WriteLine();
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
         
            List<Modelo> ListaModelos = new List<Modelo> () {
            };

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
                    DefinicaoDeVeiculo(veiculo, ListaModelos[0]);
                    break;
                case 2:
                    DefinicaoDeVeiculo(veiculo, ListaModelos[1]);
                    break;
                case 3:
                    DefinicaoDeVeiculo(veiculo, ListaModelos[2]);
                    break;
                case 4:
                    DefinicaoDeVeiculo(veiculo, ListaModelos[3]);
                    break;
                case 5:
                    DefinicaoDeVeiculo(veiculo, ListaModelos[4]);
                    break;
                case 6:
                    DefinicaoDeVeiculo(veiculo, ListaModelos[5]);
                    break;
                case 7:
                    DefinicaoDeVeiculo(veiculo, ListaModelos[6]);
                    break;
                default:
                    WriteLine ("Opção inválida!");
                    break;
                }
        }
        static void DefinicaoDeVeiculo (Veiculo veiculo, Modelo modelo) {
            int escolha = 0;
            
            veiculo.Marca = modelo.Marca;
            Write ($"[1] {modelo.Modelo1}:\n[2] {modelo.Modelo2}:\n> Escolha um dos modelos: ");
            escolha = int.Parse(Console.ReadLine());

            if (escolha == 1) {
                veiculo.Modelo = modelo.Modelo1;
            } else if (escolha == 2) {
                veiculo.Modelo = modelo.Modelo2;
            } else {
                WriteLine ("> Opção inválida! ");
            }
            Clear();
            WriteLine($"Marca: {veiculo.Marca}");
            WriteLine($"Modelo: {veiculo.Modelo}");

            CustomizarPlaca(veiculo);
            CustomizarCor(veiculo);
        }
        static void CustomizarPlaca (Veiculo veiculo){
           System.Console.WriteLine();

           WriteLine ("## CUSTOMIZANDO PLACA ## ");
           Write("> Escolha 3 Letras de A á Z: ");
           string LetrasDaPlaca = Console.ReadLine().ToUpper();

           Write("> Escolha 4 Números entre 0 à 9: ");
           int NumerosDaPlaca = int.Parse(Console.ReadLine());
           
           veiculo.Placa = LetrasDaPlaca +"-"+ NumerosDaPlaca.ToString();
           Clear();
           WriteLine($"Marca: {veiculo.Marca}");
           WriteLine($"Modelo: {veiculo.Modelo}");
           WriteLine($"Placa: {veiculo.Placa}");
        }
        static void CustomizarCor (Veiculo veiculo){
            WriteLine ("## CUSTOMIZANDO COR ## ");
                WriteLine ();
                WriteLine ("[1] Azul: ");
                WriteLine ("[2] Preto: ");
                WriteLine ("[3] Cinza: ");
                WriteLine ("[4] Vermelho: ");
                WriteLine ("[5] Roxo: ");
                WriteLine ("[6] Marrom: ");
                WriteLine ("[7] Branco: ");
            Write("> Escolha uma das cores: ");
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
                Clear();
                WriteLine($"Marca: {veiculo.Marca}");
                WriteLine($"Modelo: {veiculo.Modelo}");
                WriteLine($"Placa: {veiculo.Placa}");
                WriteLine($"Cor: {veiculo.Cor}");
        }
    }
}