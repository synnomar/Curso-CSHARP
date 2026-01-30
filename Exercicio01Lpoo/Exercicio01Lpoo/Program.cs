using Exercicio01Lpoo;
using System;

namespace MyApplication {
    class Program {

        static void Main(string[] args) {

            Pessoas p1, p2;

            p1 = new Pessoas();
            p2 = new Pessoas();

            Console.WriteLine("Digite os dados da Primeira Pessoa");
            Console.Write("Nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os dados da Segunda Pessoa: ");
            Console.Write("Nome: ");
            p2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade > p2.idade) {
                Console.WriteLine("Pessoa mais velha: {0}", p1.nome);
            } 
            else { 
                Console.WriteLine("Pessoa mais velha: {0}", p2.nome);
            }



        }
    }
}