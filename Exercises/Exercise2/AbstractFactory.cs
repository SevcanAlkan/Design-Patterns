using System;
using System.Collections.Generic;
using System.Text;
using Exercise2.Bank;
using Exercise2.Loan;

namespace Exercise2
{
    public abstract class AbstractFactory
    {
        public abstract IBank GetBank(string bank);
        public abstract LoanBase GetLoan(string loan);
    }
}
