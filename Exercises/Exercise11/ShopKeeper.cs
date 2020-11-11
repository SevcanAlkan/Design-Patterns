using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise11
{
    public class ShopKeeper
    {
        private IMobileShop IPhone11;
        private IMobileShop S20;
        private IMobileShop Z10;

        public ShopKeeper()
        {
            IPhone11 = new AppleIPhone();
            S20 = new SamsungS20();
            Z10 = new BlackberryZ10();
        }

        public void IPhoneSale()
        {
            IPhone11.modelNo();
            IPhone11.price();
        }

        public void S20Sale()
        {
            S20.modelNo();
            S20.price();
        }

        public void Z10Sale()
        {
            Z10.modelNo();
            Z10.price();
        }
    }
}
