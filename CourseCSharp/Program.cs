using System.Globalization;
using System.Collections.Generic;
using System;
using CourseCSharp.Entities;
using CourseCSharp.Entities.Exceptions;

namespace CourseCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");
                int accountNumber = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string accountHolder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawnLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(accountNumber, accountHolder, initialBalance, withdrawnLimit);
                
                Console.WriteLine(" ");
                Console.Write("Enter amount for withdraw: ");
                double amount  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                acc.Withdraw(amount);

                Console.WriteLine($"New balance: {acc.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch(DomainException e)
            {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }
            catch(FormatException e)
            {
                 Console.WriteLine($"Format input error: {e.Message}");
            }

        }
    }
}
