using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise10
{
    public abstract class FoodDecorator : IFood
    {
        private IFood newFood;

        public FoodDecorator(IFood newFood)
        {
            this.newFood = newFood;
        }

        public virtual double FoodPrice()
        {
            return newFood.FoodPrice();
        }

        public virtual string PrepareFood()
        {
            return newFood.PrepareFood();
        }
    }
}
