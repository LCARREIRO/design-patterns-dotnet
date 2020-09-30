namespace CursoDesignPatterns.Models
{
    public class Account
    {
        public double Balance { get; private set; }

        public Account(double balance)
        {
            this.Balance = balance;

        }

        public void Deposit(double value)
        {
            this.Balance += value;
        }
    }
}