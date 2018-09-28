using Banking.Models.Domain;
using System;

namespace Banking
{
    public static class Program
    {
        static void Main(string[] args)
        {
            BankAccount anotherBankAccount = new BankAccount()
            {
                AccountNumber = "123-123123123-99",
                Balance = 200
            };

            BankAccount myBA = new BankAccount("123-123123-99", 50);
            Console.WriteLine($"BankAccountNumber is {myBA.AccountNumber}");
            Console.WriteLine($"Balance is {myBA.Balance} Euro");
            myBA.Deposit(200);
            Console.WriteLine($"Balance is {myBA.Balance} Euro");
            myBA.Withdraw(50);
            Console.WriteLine($"Balance is {myBA.Balance} Euro");
            Console.ReadKey();
        }
    }
}
