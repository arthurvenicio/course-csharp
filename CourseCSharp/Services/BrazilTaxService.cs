using CourseCSharp.Entities.Interfaces;

namespace CourseCSharp.Services
{
    public class BrazilTaxService : ITaxService
    {
        public double Tax(double amount)
        {
            if(amount > 100.0)
            {
                return amount * 0.15;
            }

            return amount * 0.2;
        }
    }
}