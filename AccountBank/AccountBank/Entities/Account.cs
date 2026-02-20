using System;
using System.Globalization;

namespace AccountBank.Entities
{
    class Account
    {

        public int Number {  get; private set; }
        public string Holder { get; private set; }
        public double Balance {  get; protected set; }


        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5;
        }

        public void Deposit(double amount) 
        {
            Balance += amount;
        }
        public override string ToString()
        {
            return "Number of Account: " + Number
            + "\nName: " + Holder
            + "\nBalance: $" + Balance.ToString("F2", CultureInfo.InvariantCulture)
            
            ;

        }   
    }
}
