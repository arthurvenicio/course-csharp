namespace CourseCSharp.Entities
{
    public class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            this.Number = number;
            this.Holder = holder;
            this.Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            this.Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
        }

    }
}