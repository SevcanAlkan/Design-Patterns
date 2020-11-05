using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3.Bank
{
    public class SBI : IBank
    {
        private readonly string _bankName;

        public SBI()
        {
            _bankName = "SBI BANK";
        }

        public string GetBankName()
        {
            return _bankName;
        }
    }
}
