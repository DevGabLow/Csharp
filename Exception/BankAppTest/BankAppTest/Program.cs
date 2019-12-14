using System;
using BankAppTest.Entities;
using BankAppTest.Entities.Exceptions;
namespace BankAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial Balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw Limit: ");
            double withlimit = double.Parse(Console.ReadLine());

            Account acc = new Account(number,holder,balance,withlimit);

            Console.Write("Enter amount for withdraw: ");
            double with = double.Parse(Console.ReadLine());

            try
            {
                acc.WithDraw(with);
                Console.WriteLine("New balance: " + acc.Balance.ToString("F2"));
            }
            catch(DomainExceptions m)
            {
                Console.WriteLine("Withdraw error:  " + m.Message);
            }
        }
    }
}
