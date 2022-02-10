using System;
using System.Collections.Generic;

namespace CourseCSharp.Entities
{
    public class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        public List<Installment> Installments { get; set; }

        public Contract(int number, DateTime date, double totalValue)
        {
            this.Number = number;
            this.Date = date;
            this.TotalValue = totalValue;
        }

        public void AddInstallment(Installment installment)
        {
            Installments.Add(installment);
        }
        
    }
}