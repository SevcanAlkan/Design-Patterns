using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise12
{
    public class RealInternetAccess : IOfficeInternetAccess
    {
        private string employeeName;

        public RealInternetAccess(string employeeName)
        {
            this.employeeName = employeeName;
        }

        public void GrantInternetAccess()
        {
            Console.WriteLine($"Internet access granted for employee {employeeName}");
        }
    }
}
