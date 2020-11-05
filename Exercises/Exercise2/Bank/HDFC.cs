using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3.Bank
{
    public class HDFC : IBank
    {
        private readonly string _bankName;

        public HDFC()
        {
            _bankName = "HDFC BANK";
        }

        public string GetBankName()
        {
            return _bankName;
        }
    }
}
