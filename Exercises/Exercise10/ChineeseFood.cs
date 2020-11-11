using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise10
{
    public class ChineeseFood : FoodDecorator
    {
        public ChineeseFood(IFood newFood) : base(newFood)
        {
        }

        public override string PrepareFood()
        {
            return base.PrepareFood() + " with fried rice and manchurian  ";
        }

        public override double FoodPrice()
        {
            return base.FoodPrice() + 65.0;
        }
    }
}
