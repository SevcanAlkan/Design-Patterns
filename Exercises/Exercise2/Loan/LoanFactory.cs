using Exercise2.Bank;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2.Loan
{
    public class LoanFactory : AbstractFactory
    {
        public override IBank GetBank(string bank) =>
            null;

        public override LoanBase GetLoan(string loan) =>
            loan.Trim().ToUpper() switch
            {
                "HOME" => new HomeLoan(),
                "BUSINESS" => new BussinessLoan(),
                "EDUCATION" => new EducationLoan(),
                _ => null
            };
    }
}
