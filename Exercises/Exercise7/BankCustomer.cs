using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise7
{
    public class BankCustomer : BankDetails, ICreditCard
    {
        public BankCustomer()
        {

        }

        public string GetCreditCard()
        {
            return $"The Account number: {AccountNumber} of {AccountHolderName} in {BankName} bank is valid and authenticated for issuing the credit card";
        }

        public void GiveBankDetails()
        {
            try
            {

                Console.Write("Enter the Account Holder Name: ");
                AccountHolderName = Console.ReadLine().Trim().ToUpper();

                Console.Write("Enter the Account Number: ");
                long.TryParse(Console.ReadLine().Trim().ToUpper(), out long AccountNumber);

                Console.Write("Enter the Bank Name: ");
                BankName = Console.ReadLine().Trim().ToUpper();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
