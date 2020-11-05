using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise2
{
    class GenerateBill
    {
        public GenerateBill()
        {

        }

        public static void Generate()
        {
            GetPlanFactory planFactory = new GetPlanFactory();

            string planType = string.Empty;
            bool isAlreadyRequested = false;

            do
            {
                if (isAlreadyRequested)
                    Console.WriteLine("Please enter valid input!");

                Console.Write("Enter the name of plan for which the bill will be generated: ");
                planType = Console.ReadLine().Trim().ToUpper();

                isAlreadyRequested = true;
            } while (planType == string.Empty
                || (!planType.Equals("INSTITUTIONALPLAN")
                    && !planType.Equals("COMMERCIALPLAN")
                    && !planType.Equals("DOMESTICPLAN")
                ));

            bool isUnitCountValid = false;
            int units = 0;

            do
            {
                Console.Write("Enter the number of units for bill will be calculeted: ");

                if (int.TryParse(Console.ReadLine().Trim().ToUpper(), out int unitInput))
                {
                    isUnitCountValid = true;
                    units = unitInput;
                }
                else
                {
                    Console.WriteLine("Please enter valid input!");
                }
            } while (!isUnitCountValid);

            Plan plan = planFactory.GetPlan(planType);
            plan.GetRate();

            Console.WriteLine($"Bill amount for {planType} of {units} units is: {plan.CalculateBill(units)}");
        }
    }
}
