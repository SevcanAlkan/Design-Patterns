using Exercise2.Bank;
using Exercise2.Loan;
using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter bank name: ");
            string bankName = Console.ReadLine().Trim().ToUpper();

            Console.Write("Enter loan type: ");
            string loanName = Console.ReadLine().Trim().ToUpper();

            AbstractFactory bankFactory = FactoryCreator.GetFactory("Bank");
            AbstractFactory loanFactory = FactoryCreator.GetFactory("Loan");

            IBank bank = bankFactory.GetBank(bankName);

            Console.Write($"Enter interest rate for {bank.GetBankName()} :");
            double.TryParse(Console.ReadLine().Trim(), out double rate);

            Console.Write("Enter the loan amount: ");
            double.TryParse(Console.ReadLine().Trim(), out double loanAmount);

            Console.Write("Enter the number of years to pay entire loan amount: ");
            int.TryParse(Console.ReadLine().Trim(), out int years);

            Console.WriteLine($"You are taking the loan form {bank.GetBankName()}");

            LoanBase loan = loanFactory.GetLoan(loanName);

            loan.GetInterestRate(rate);
            loan.CalculateLoadnPayment(loanAmount, years);

            Console.ReadKey();
        }
    }
}
