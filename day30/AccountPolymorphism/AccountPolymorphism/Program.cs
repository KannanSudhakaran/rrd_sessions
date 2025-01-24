using System;
using AccountPolymorphism.Models;

namespace AccountPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CaseStudy1();

            SavingAccount savingAccount = new SavingAccount("101", "abc", 1000);
            PrintBalanceSheet(savingAccount);



        }

        private static void CaseStudy1()
        {
            Account account;//expects only subclasses
            account = new SavingAccount("101", "AccHolder1", 1000);
            PrintBalanceSheet(account);
            account = new CurrentAccount("102", "AccHolder2", 4000);
            PrintBalanceSheet(account);
        }

        //OCP-->OpenClosedPrinciple
        //Open for adding new features,without modifying existing tested code
        static void PrintBalanceSheet(Account account) {
            Console.WriteLine($" Account no is {account.Id}" +
                $" name is  {account.Name}" +
                $" Balance is  {account.Balance}");
            Console.Write($"type of account {account.Type}");

            //if (account is SavingAccount)
            //{
            //    Console.WriteLine("SavingAccount");
            //}
            //else if (account is CurrentAccount)
            //{
            //    {
            //        Console.WriteLine("CurrentAccount")
            //    }

            //    //  Console.WriteLine("account type is :"+account.GetType().Name);

           }
    }
}
