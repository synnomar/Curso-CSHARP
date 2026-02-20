using AbstractBankAccount.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {

           List<Account> accountsList = new List<Account>();

            accountsList.Add(new SavingsAccount(1001,"Alex", 500.00, 0.01));
            accountsList.Add(new BusinessAccount(1002, "Maria", 500.00, 400.00));
            accountsList.Add(new SavingsAccount(1003, "Bob", 500.00, 0.01));
            accountsList.Add(new BusinessAccount(1004,"Anna", 500.00, 500.00));
            accountsList.Add(new BusinessAccount(1005, "Sinomar", 2500.00, 500.00));


            double sum = 0;
            foreach (Account account in accountsList) 
            {
                sum += (account.Balance);
            }

            Console.WriteLine("Total balance: $ "+sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Account account in accountsList)
            {
                account.Withdraw(10);
            }

            foreach (Account account in accountsList)
            {
                Console.WriteLine("Udated balance for account "
                    +account.Number 
                    +": "
                    + account.Holder
                    + ": "
                    + account.Balance.ToString("F2", CultureInfo.InvariantCulture)
                    
                    );
            }

        }
    }
}