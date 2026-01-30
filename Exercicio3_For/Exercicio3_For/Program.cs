using System;
using System.Data;

namespace Curso {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite a quantidade de insersão: ");
            int n = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= n; i++) {
                double val1 = 0.0;
                double val2 = 0.0;
                double val3 = 0.0;
                double media = 0.0;

                for (int j = 1; j <= 3; j++) {
                    Console.Write($"Digite as notas {j}: ");
                    double x = double.Parse(Console.ReadLine());
                    if (j == 1) {
                        val1 += x * 2;
                    } else if (j == 2) {
                        val2 += x * 3;
                    } else if (j == 3) {
                        val3 += x * 5;
                    }
                }
                media = (val1 + val2 + val3) / 10;
                Console.WriteLine($"Media {media:F1}" );
                
            }           
        }              
     }
} 
