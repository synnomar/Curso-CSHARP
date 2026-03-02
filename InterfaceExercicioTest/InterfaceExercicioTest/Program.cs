using System;
using System.Globalization;
using InterfaceExercicioTest.Entities;
using InterfaceExercicioTest.Services;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER CONTRACT DATA");
            Console.Write("NUMBER: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("DATE (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse (Console.ReadLine());
            Console.Write("CONTRACT VALUE: ");
            double contractValue = double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("ENTER NUMBER OF INSTALLMENTS: ");
            int numberOfInstallment = int.Parse(Console.ReadLine());

            Contract contract = new Contract (number, date, contractValue);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, numberOfInstallment);

            Console.WriteLine("INSTALLMENTS: ");
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
           









        }        
    }
}