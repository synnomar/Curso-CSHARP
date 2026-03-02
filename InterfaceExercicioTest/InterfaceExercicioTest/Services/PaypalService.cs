using System;
using System.Collections.Generic;

namespace InterfaceExercicioTest.Services
{
    class PaypalService : IOnlinePaymentService
    {

        public const double FeePercentage = 0.02;
        public const double MonthlyInterest = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }

        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }

       
    }
}
