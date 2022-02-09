using CourseCSharp.Entities.Exceptions;

namespace CourseCSharp.Entities
{
    public class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }
        public double WithdrawLimit {get; protected set;}

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            this.Number = number;
            this.Holder = holder;
            this.Balance = balance;
        }

        public Account(int number, string holder, double balance, double withdrawnLimit)
        {
            this.Number = number;
            this.Holder = holder;
            this.Balance = balance;
            this.WithdrawLimit = withdrawnLimit;
        }

        public virtual void Withdraw(double amount)
        {
            if(amount > WithdrawLimit){
                throw new DomainException("The amount exceeds withdraw limit");
            }

            if(amount > Balance){
                throw new DomainException("Not enough balance");
            }

            this.Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
        }

    }
}