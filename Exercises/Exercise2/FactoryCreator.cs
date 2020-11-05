using Exercise3.Bank;
using Exercise3.Loan;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3
{
    public class FactoryCreator
    {
        public static AbstractFactory GetFactory(string choice)
        {
            if (choice.Trim().ToUpper().Equals("BANK"))
            {
                return new BankFactory();
            }
            else if (choice.Trim().ToUpper().Equals("LOAN"))
            {
                return new LoanFactory();
            }
            else
            {
                return null;
            }
        }
    }
}
