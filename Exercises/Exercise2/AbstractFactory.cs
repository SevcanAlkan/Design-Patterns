using System;
using System.Collections.Generic;
using System.Text;
using Exercise3.Bank;
using Exercise3.Loan;

namespace Exercise3
{
    public abstract class AbstractFactory
    {
        public abstract IBank GetBank(string bank);
        public abstract LoanBase GetLoan(string loan);
    }
}
