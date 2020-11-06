using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise5
{
    public class Sony : Company
    {
        public override string Pack()
        {
            return "Sony CD";
        }

        public override int Price()
        {
            return 20;
        }
    }
}
