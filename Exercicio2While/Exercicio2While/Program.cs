using System;

namespace Curso {
    class Program {
        static void Main(string[] args) {
            int z = 0;

            while (z != 1) {
                Console.Write("digite a coordenadas x: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("digite a coordenadas y: ");
                int y = int.Parse(Console.ReadLine());

                if (x > 0 && y > 0) {
                    Console.WriteLine("Primeiro!");
                } else if (x < 0 && y > 0) {
                    Console.WriteLine("Segundo! ");
                } else if (x < 0 && y < 0) {
                    Console.WriteLine("Terceiro");
                } else if (x > 0 && y < 0) {
                    Console.WriteLine("Quarto");
                } else if (x == 0 || y ==0 ){ 
                    z = 1; 
                }
            }
        
        }
    }
}