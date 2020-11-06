using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    public abstract class Company : IPacking
    {
        public abstract string Pack();

        public abstract int Price();
    }
}
