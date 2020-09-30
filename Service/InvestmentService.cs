using CursoDesignPatterns.Interfaces;
using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.Service
{
    public class InvestmentService
    {
        public void Calculates(Account account, IInvestment investment)
        {
            System.Console.WriteLine($"Saldo atual: {account.Balance}");
            double result = investment.Calculates(account);
            account.Deposit(result * 0.75);
            System.Console.WriteLine($"Novo saldo: {account.Balance}");
        }
    }
}