using Exercise2.Loan;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2.Bank
{
    public class BankFactory : AbstractFactory
    {
        public override IBank GetBank(string bank) =>
            bank.Trim().ToUpper() switch
            {
                "HDFC" => new HDFC(),
                "ICICI" => new ICICI(),
                "SBI" => new SBI(),
                _ => null
            };

        public override LoanBase GetLoan(string loan) => null;
    }
}
