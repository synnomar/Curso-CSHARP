using System;
using System.Globalization;

namespace MyApplication {
    public class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite um numero");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++) {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);            
            }

            double soma = 0.0;

            for (int i = 0; i < n; i++) {
                soma += vect[i];
            }

            Console.WriteLine($"AVERAGE HEIGHT = " + (soma / n).ToString("F2", CultureInfo.InvariantCulture));
        
        
        
        
        
        
        
        
        
        }    
    }
}
