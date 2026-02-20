using System;
using System.Collections.Generic;


namespace AbstractBankAccount.Entities
{
<<<<<<< HEAD
    abstract class Account
=======
    class Account
>>>>>>> 9c65009927c0e9a4b7b819ceb3352ba3923c39f6
    {

        public int Number {  get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }

        public Account() 
        { 
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
