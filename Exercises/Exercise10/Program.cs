using System;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;

            do
            {
                Console.WriteLine("======== Food Menu ========");
                Console.WriteLine("1. Vegetarian Food");
                Console.WriteLine("2. Non-Vegetarian Food");
                Console.WriteLine("3. Chineese Food");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choise: ");

                int.TryParse(Console.ReadLine().Trim(), out input);

                IFood food = input switch
                {
                    1 => new VegFood(),
                    2 => new NonVegFood((IFood) new VegFood()),
                    3 => new ChineeseFood((IFood)new VegFood()),
                    _ => null
                };

                if(food != null)
                {
                    Console.WriteLine(food.PrepareFood());
                    Console.WriteLine(food.FoodPrice());
                }
            } while (input != 4);


            Console.ReadKey();
        }
    }
}
