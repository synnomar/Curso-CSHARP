using ExercicioFix02Lpoo;
using System;

namespace MyApplication {
    public class Program {
        static void Main(string[] args) {
            
            Funcionario funcionario = new Funcionario();

            Console.WriteLine(" Entre com os dados do Funcionario: ");
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            funcionario.SalarioBruno = double.Parse(Console.ReadLine());
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(funcionario);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salario:  ");
            double aumento = double.Parse(Console.ReadLine());
            funcionario.AumentarSalario(aumento);
            Console.WriteLine(funcionario);

        }
    }
}
