using ExercicioFix03Lpoo;
using System;

namespace Myapplication {
    class Program {
        static void Main(string[] args) {
            Aluno aluno = new Aluno();

            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            aluno.Nota2 = double.Parse(Console.ReadLine());
            aluno.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine(aluno);
        }
    }
}