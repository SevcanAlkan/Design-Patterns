using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee emp1 = new Cashier(101, "Sohan Kumar", 2000.0);
            IEmployee emp2 = new Cashier(102, "Mohan Kumar", 25000.0);
            IEmployee emp3 = new Accountant(103, "Seema Mahiwal", 30000.0);

            IEmployee manager = new BankManager(100, "Ashwani Rasjput", 100000.0);

            manager.Add(emp1);
            manager.Add(emp2);
            manager.Add(emp3);

            manager.Print();

            Console.ReadKey();
        }
    }
}
