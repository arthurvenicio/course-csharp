using System;
using CourseCSharp.Entities;

namespace CourseCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Arthur", 5000.00, 300.00);
            Account bacc1 = new BusinessAccount(1003, "Arthur", 5000.00, 300.00);


            Account acc1 = bacc;
            BusinessAccount bacc2 = (BusinessAccount)bacc1;
            
            bacc2.Loan(100.00);
        }
    }
}
