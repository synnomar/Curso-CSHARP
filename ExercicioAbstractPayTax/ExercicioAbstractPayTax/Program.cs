using ExercicioAbstractPayTax.Entities;
using System;
using System.Globalization;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> listTaxPayers = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int numOption = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numOption; i++) {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char optionPayer = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (optionPayer == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpanded = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listTaxPayers.Add(new PessoaFisica(name, income, healthExpanded));
                    Console.WriteLine();
                }
                else if(optionPayer == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());
                    listTaxPayers.Add(new PessoaJuridica(name, income, numberEmployees));
                    Console.WriteLine();
                }
            }

            Console.WriteLine("TAXES PAID: ");
            double sum = 0.0;
            foreach (TaxPayer taxPayer in listTaxPayers)
            {
                double sumPrint = taxPayer.CalcTax();
                sum += sumPrint;
                Console.WriteLine(taxPayer.Name+": $ "+ sumPrint.ToString("F2", CultureInfo.InvariantCulture));

            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: "+ sum.ToString("F2", CultureInfo.InvariantCulture));
          







        }
    }
}
