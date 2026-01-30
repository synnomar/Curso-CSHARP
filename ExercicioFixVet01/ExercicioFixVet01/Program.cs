using ExercicioFixVet01;
using System;

namespace MyApplycation {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantas hospedagem seram realizada?: ");
            
            int qteHosp = int.Parse(Console.ReadLine());

            Hospedagem[] hospedagem = new Hospedagem[10];

            for (int i = 0; i < qteHosp; i++) {
                Console.WriteLine("Rent #"+ (i+1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int numQuarto = int.Parse(Console.ReadLine());
                Console.WriteLine();

                for (int x = 0; x < 10; x++) {
                    if (x == numQuarto) {
                        hospedagem[numQuarto] = new Hospedagem(nome, email);
                    }
                }
            }

            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < 10; i++) {
                if (hospedagem[i] != null) {
                    Console.WriteLine(i
                        + ": "
                        + hospedagem[i].Nome
                        + ", "
                        + hospedagem[i].Email);
                }

            }
        
        }
    }
}