using System;

namespace revisao_s01_a_s04
{
    class Program
    {
        static void Main(string[] args){
            
            int maiorIdade = 0;
            string nome = "";

            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Ler os nomes e idades e retornar a maior idade: ");
            Console.WriteLine("");
            
            for(int i = 1; i <= 3; i++){

                System.Console.WriteLine("Dados da "+i+"° pessoa:");
                System.Console.Write("Nome: ");
                pessoa.Nome = Console.ReadLine();

                System.Console.Write("Idade: ");
                pessoa.Idade = int.Parse(Console.ReadLine());

                System.Console.WriteLine("");

                if(pessoa.Idade > maiorIdade){
                    nome = pessoa.Nome;
                    maiorIdade = pessoa.Idade;
                }

            }
            System.Console.WriteLine("");
            System.Console.WriteLine($"{nome} Tem a maior idade: {maiorIdade} anos");
            System.Console.WriteLine("");
        }
    }
}
