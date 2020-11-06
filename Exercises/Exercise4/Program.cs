using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter employee Id: ");
            int.TryParse(Console.ReadLine().Trim(), out int eId);

            Console.Write("Enter employee Name: ");
            string eName = Console.ReadLine().Trim();

            Console.Write("Enter employee Designation: ");
            string eDesignation = Console.ReadLine().Trim();

            Console.Write("Enter employee Address: ");
            string eAddress = Console.ReadLine().Trim();

            Console.Write("Enter employee Salary: ");
            double.TryParse(Console.ReadLine().Trim(), out double eSalary);

            Console.WriteLine();

            EmployeeRecord e1 = new EmployeeRecord(eId, eName, eDesignation, eAddress, eSalary);

            e1.ShowRecord();

            EmployeeRecord e2 = (EmployeeRecord)e1.GetClone();

            e2.ShowRecord();

            Console.ReadKey();
        }
    }
}
