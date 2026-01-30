using System;

namespace Curso {
    class Program {

        static void Main(string[] args) {
            Console.Write("Digite um numero: ");
            int x = int.Parse(Console.ReadLine());

                for(int i = 1; i <= x; i++) {

                    if (i % 2 == 1) {

                        Console.WriteLine(i);
                    }

                }

        }
    }
}