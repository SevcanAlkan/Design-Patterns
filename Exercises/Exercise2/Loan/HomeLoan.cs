﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2.Loan
{
    public class HomeLoan : LoanBase
    {
        public override void GetInterestRate(double rate)
        {
            _rate = rate;
        }
    }
}
