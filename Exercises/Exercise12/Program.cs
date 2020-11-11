using System;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            IOfficeInternetAccess access = new ProxyInternetAccess("Ashwani Rajut");

            access.GrantInternetAccess();

            Console.ReadKey();
        }
    }
}
