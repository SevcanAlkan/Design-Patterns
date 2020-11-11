using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise10
{
    public class VegFood : IFood
    {
        public double FoodPrice()
        {
            return 50.0;
        }

        public string PrepareFood()
        {
            return "Veg Food";
        }
    }
}
