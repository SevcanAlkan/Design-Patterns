using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise9
{
    public class Accountant : IEmployee
    {
        private int id;
        private string name;
        private double salary;

        public Accountant(int id, string name, double salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public void Add(IEmployee employee)
        {
        }

        public IEmployee GetChild(int i)
        {
            return null;
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
        }

        public void Remove(IEmployee employee)
        {
        }
    }
}
