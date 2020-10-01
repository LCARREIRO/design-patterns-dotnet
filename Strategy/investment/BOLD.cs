using System;
using CursoDesignPatterns.Strategy.Interfaces;
using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.Strategy.investment
{
    // ARROJADO", que tem 20% de chances de retornar 5%, 30% de chances de retornar 3%, 
    // e 50% de chances de retornar 0.6%.

    public class BOLD : IInvestment
    {
        private Random random;

        public BOLD()
        {
            random = new Random();
        }
        public double Calculates(Account account)
        {
            int test = random.Next(101);

            if (test == 20)
            {
                return account.Balance * 0.5;
            }
            else if (test == 50)
            {
                return account.Balance * 0.6;
            }
            else
            {
                return account.Balance * 0.3;
            }
        }
    }
}