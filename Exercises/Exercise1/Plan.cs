using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    abstract class Plan
    {
        protected double rate;

        public abstract void GetRate();

        public string CalculateBill(int units)
        {
            return $"UNITS*RATE: {units * rate}";
        }
    }
}
