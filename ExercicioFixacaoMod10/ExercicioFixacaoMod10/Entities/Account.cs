using ExercicioFixacaoMod10.Entities.Exceptions;
using System;

namespace ExercicioFixacaoMod10.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Hoder {  get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string hoder, double balance, double withdrawLimit)
        {
            Number = number;
            Hoder = hoder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds Withdraw limit");
            }

            if (amount > Balance)
            {
                throw new DomainException("Not enouth balance");
            }

    

            Balance -= amount;
        }
    }
}
