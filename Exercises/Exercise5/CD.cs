using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    public abstract class CD : IPacking
    {
        public abstract string Pack();

        public abstract int Price();
    }
}
