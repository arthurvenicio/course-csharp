using System.Globalization;
namespace CourseCSharp.Entities
{
    public class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            this.BasicPayment = basicPayment;
            this.Tax = tax;
        }

        public double TotalPayment
        {
           get { return BasicPayment + Tax;} 
        }


        public override string ToString()
        {
            return "Basic payment: " 
            + this.BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTax: "
            + this.Tax.ToString("F2", CultureInfo.InvariantCulture)
            + "\nTotal payment: "
            + this.TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}