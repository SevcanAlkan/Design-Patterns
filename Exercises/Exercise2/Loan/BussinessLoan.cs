using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3.Loan
{
    public class BussinessLoan : LoanBase
    {
        public override void GetInterestRate(double rate)
        {
            _rate = rate;
        }
    }
}
