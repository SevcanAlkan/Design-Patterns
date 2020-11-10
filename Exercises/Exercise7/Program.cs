using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditCard creditCard = new BankCustomer();

            creditCard.GiveBankDetails();

            Console.WriteLine(creditCard.GetCreditCard());

            Console.ReadKey();
        }
    }
}
