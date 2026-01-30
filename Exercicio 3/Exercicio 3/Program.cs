using System;

namespace Curso {
    class Program {
        static void Main(string[] args) {
            int codAlcool = 0;
            int codGas = 0;
            int codDiesel = 0;
            int sair = 0;
            Console.WriteLine("Entre na Rotina de Abastecimento");

            while (sair != 4) {
                Console.WriteLine("Digite o Codigo: ");
                Console.WriteLine("1 - Alcool ");
                Console.WriteLine("2 - Gasolina");
                Console.WriteLine("3 - Diesel ");
                Console.WriteLine("4 - Sair");
                int x = int.Parse(Console.ReadLine());
                if (x == 1) {
                    codAlcool++;

                } else if (x == 2) {
                    codGas++;
                } else if (x == 3) {
                    codDiesel++;
                } else if (x == 4) {
                    sair = 4;
                } else {
                    Console.WriteLine("Codigo Invalido");
                }
            }
            Console.WriteLine("Imprimir relatorio de abastecimento");
            Console.WriteLine($"ALCOOL: {codAlcool}");
            Console.WriteLine($"GASOLINA: {codGas}");
            Console.WriteLine($"DISIEL: {codDiesel}");
            Console.WriteLine("MUITO OBRIGADO!");
            


        }
    }
}