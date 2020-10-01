namespace CursoDesignPatterns.ChainOfResponsibility.Models
{
    public class Account
    {
        public double Balance { get; private set; }
        public string Holder { get; private set; }

        public Account(double balance, string holder)
        {
            this.Balance = balance;
            this.Holder = holder;
        }
    }
}