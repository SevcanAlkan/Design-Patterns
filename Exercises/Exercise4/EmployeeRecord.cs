using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    public class EmployeeRecord : IPrototype
    {
        private int Id;
        private string Name, Designation, Address;
        private double Salary;

        public EmployeeRecord()
        {
            Console.WriteLine("Employee records of Oracle Corp.");
            Console.WriteLine("-".PadRight(20));
            ShowRecord();
        }

        public EmployeeRecord(int id, string name, string designation, string address, double salary) : base()
        {
            Id = id;
            Name = name;
            Address = address;
            Designation = designation;
            Salary = salary;
        }

        public void ShowRecord()
        {
            Console.WriteLine($@"
                ID: {Id}
                NAME: {Name}
                DESIGANATION: {Designation}
                ADDRESS: {Address}
                SALARY: {Salary}
            ");
        }

        public IPrototype GetClone()
        {
            return new EmployeeRecord(Id, Name, Designation, Address, Salary);
        }
    }
}
