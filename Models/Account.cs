using System.Collections.Generic;

namespace CursoDesignPatterns.Models
{
    public class Account
    {
        public string Holder { get; private set; }
        public double Balance { get; private set; }
        public string Agency { get; private set; }
        public string Number { get; private set; }
        public Account(double balance, string holder, string agency, string number)
        {
            this.Holder = holder;
            this.Balance = balance;
            this.Number = number;
            this.Agency = agency;
        }
        public void Deposit(double value)
        {
            this.Balance += value;
        }
    }
}