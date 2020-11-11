using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise12
{
    public class ProxyInternetAccess : IOfficeInternetAccess
    {
        private string employeeName;
        private RealInternetAccess realInternetAccess;

        public ProxyInternetAccess(string employeeName)
        {
            this.employeeName = employeeName;
        }

        public void GrantInternetAccess()
        {
            if(getRole(employeeName) > 4)
            {
                realInternetAccess = new RealInternetAccess(employeeName);
                realInternetAccess.GrantInternetAccess();
            }
            else
            {
                Console.WriteLine("No internet access granted. Your job level is below 5");
            }
        }

        private int getRole(string employeeName)
        {
            return 2;
        }
    }
}
