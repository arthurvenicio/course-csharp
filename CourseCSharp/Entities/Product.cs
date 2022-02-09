namespace CourseCSharp.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product()
        {
        }

        public Product(string name, double price, int quantity){
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public double Total()
        {
            return Quantity * Price;
        }
    }
}