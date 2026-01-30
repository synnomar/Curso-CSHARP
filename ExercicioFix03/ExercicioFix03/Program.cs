using ExercicioFix03;
using System;

namespace MyApplication {
    class Program {
        static void Main(string[] args) {
            ConversorDeMoeda conversorDeMoeda = new ConversorDeMoeda();

            Console.Write("Qual é a cotação do dólar: ");
            conversorDeMoeda.Dolar = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar?: ");
            conversorDeMoeda.CompraDolar = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor a ser pago em Reais = "+ conversorDeMoeda.ConverterMoeda());

        
        }
    }
}