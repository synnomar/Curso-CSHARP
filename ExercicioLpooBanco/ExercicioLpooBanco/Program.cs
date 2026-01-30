using ExercicioLpooBanco;
using System;
using System.Globalization;
using System.Security.Cryptography;


namespace MyApplication {
    public class Program {

        static void Main(string[] args) {
            ContaBancaria conta;
            Console.WriteLine("BEM VINDO AO SISTEMA BANCARIO");

            Console.Write("Entre com o numero da conta: ");
            int numConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o Titular da Conta: ");
            string nomeTitular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (S/N): ");
            char depinicial = char.Parse(Console.ReadLine());
            
            if (depinicial == 'S' || depinicial == 's') {
                    Console.WriteLine();
                    Console.Write("Entre com o deposito inicial: ");
                    double valorInicial = double.Parse(Console.ReadLine());
                    conta = new ContaBancaria(numConta, nomeTitular, valorInicial);
             }
            else {  
                    conta = new ContaBancaria(numConta, nomeTitular);
                    
                    
             }
            Console.WriteLine();
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com valor do Depósito: ");
            conta.DepositoConta(double.Parse(Console.ReadLine() ));
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com valor do Saque: ");
            conta.SaqueConta(double.Parse(Console.ReadLine()));
            Console.WriteLine(conta);








        }
    }
}