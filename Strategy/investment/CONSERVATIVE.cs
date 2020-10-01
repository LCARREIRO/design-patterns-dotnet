using CursoDesignPatterns.Strategy.Interfaces;
using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.Strategy.investment
{
    public class CONSERVATIVE : IInvestment
    {
        public double Calculates(Account account)
        {
            return account.Balance * 0.8; 
        }
    }
}