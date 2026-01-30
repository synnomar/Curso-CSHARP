using System;

namespace Curso {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o numero de entradas: ");
            int n = int.Parse(Console.ReadLine());
            int contIn = 0; 
            int contOut = 0;  

            for (int i = 0; i < n; i++) {
                Console.Write("Digite um numero: ");
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20) {
                    contIn++;
                } else {
                    contOut++;
                }                
            }
            Console.WriteLine($"{contIn} in");
            Console.WriteLine($"{contOut} out");
        }
    }
}