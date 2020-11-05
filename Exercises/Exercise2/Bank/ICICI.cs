using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2.Bank
{
    public class ICICI : IBank
    {
        private readonly string _bankName;

        public ICICI()
        {
            _bankName = "ICICI BANK";
        }

        public string GetBankName()
        {
            return _bankName;
        }
    }
}
