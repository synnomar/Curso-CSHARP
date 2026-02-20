using System;
using System.Globalization;

namespace AccountBank.Entities
{
    class BusinessAccount : Account
    {
      
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanlimit) : base(number, holder, balance)
        {
            LoanLimit = loanlimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Deposit(amount);
            }
        }

        public override string ToString()
        {
            return "Number of Account: " + Number
            + "\nName: " + Holder
            + "\nBalance: $" + Balance.ToString("F2", CultureInfo.InvariantCulture)
            + "\nLoan Limit: $"+LoanLimit.ToString("F2", CultureInfo.InvariantCulture)
            ;
        }
    }
    }
