using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise11
{
    public class AppleIPhone : IMobileShop
    {
        public void modelNo()
        {
            Console.WriteLine("Apple IPhone 11");
        }

        public void price()
        {
            Console.WriteLine("Rs 65000.00");
        }
    }
}
