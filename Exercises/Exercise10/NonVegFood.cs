using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise10
{
    public class NonVegFood : FoodDecorator
    {
        public NonVegFood(IFood newFood) : base(newFood)
        {
        }

        public override string PrepareFood()
        {
            return base.PrepareFood() + " with reasted chicken and chicken curry  ";  
        }

        public override double FoodPrice()
        {
            return base.FoodPrice() + 150.0;
        }
    }
}
