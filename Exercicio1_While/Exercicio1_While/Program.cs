using System;
using System.Globalization;

namespace Curso {

    class Program {
        static void Main(string[] args) {

            Console.Write("Digite sua Senha: ");
            double senha = double.Parse(Console.ReadLine());

            while (senha != 2002) {
                Console.WriteLine("Senha Invalida!");
                Console.Write("Digite sua Senha: ");
                senha = double.Parse(Console.ReadLine());

            }
            Console.WriteLine("Acesso Permitido");


        }
    }
}