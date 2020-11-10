using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise9
{
    public class BankManager : IEmployee
    {
        private int id;
        private string name;
        private double salary;

        private List<IEmployee> employees = new List<IEmployee>();

        public BankManager(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public void Add(IEmployee employee)
        {
            employees.Add(employee);
        }

        public IEmployee GetChild(int i)
        {
            return employees[i];
        }

        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public double GetSalary()
        {
            return salary;
        }

        public void Print()
        {
            Console.WriteLine("".PadLeft(50, '='));

            Console.WriteLine($"ID= {GetId()}");
            Console.WriteLine($"NAME= {GetName()}");
            Console.WriteLine($"SALARY= {GetSalary()}");

            Console.WriteLine("".PadLeft(50, '='));

            var it = employees.GetEnumerator();

            try
            {
                it.MoveNext();

                do
                {
                    it.Current.Print();
                    it.MoveNext();
                } while (it.Current != null);
            }
            catch (Exception)
            {
            }
        }

        public void Remove(IEmployee employee)
        {
            employees.Remove(employee);
        }
    }
}
