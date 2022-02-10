using System;
namespace CourseCSharp.Entities
{
    public class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            this.Start = start;
            this.Finish = finish;
            this.Vehicle = vehicle;
        }
    }
}