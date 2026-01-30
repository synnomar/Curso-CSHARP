using Exercicio02Lpoo;
using System;
using System.Runtime.Serialization;
using System.Globalization;

namespace MyApplication {
    class Program {
        static void Main(string[] args) {

            Funcionario p1 = new Funcionario();
            Funcionario p2 = new Funcionario();


            Console.WriteLine("Dados do primeiro funcionário");
            Console.Write("Nome: ");
            p1.Name = Console.ReadLine();
            Console.Write("Salario: ");
            p1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionário");
            Console.Write("Nome: ");
            p2.Name = Console.ReadLine();
            Console.Write("Salario: ");
            p2.Salario = double.Parse(Console.ReadLine());

            double media = (p1.Salario + p2.Salario) / 2;

            Console.WriteLine("Salario médio = "+ media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}