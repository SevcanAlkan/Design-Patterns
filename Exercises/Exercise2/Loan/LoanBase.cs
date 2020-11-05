using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2.Loan
{
    public abstract class LoanBase
    {
        protected double _rate;
        public abstract void GetInterestRate(double rate);

        public void CalculateLoadnPayment(double loanAmount, int years)
        {
            double EMI = 0.0;
            int n;

            n = years * 12;
            _rate = _rate / 1200;

            EMI = ((_rate * Math.Pow((1 + _rate), n)) / ((Math.Pow((1 + _rate), n)) - 1)) * loanAmount;

            Console.WriteLine($"your's mounhly EMI is {EMI} for the amount {loanAmount} you have borrowed");
        }
    }
}
