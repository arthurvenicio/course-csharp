using CourseCSharp.Entities;
using CourseCSharp.Services;
using System.Globalization;
using System;
using System.IO;

namespace CourseCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contact value: ");
            double value = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int n = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, n);

            Console.WriteLine("Installments:");
            foreach(Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }

        }
    }
}
