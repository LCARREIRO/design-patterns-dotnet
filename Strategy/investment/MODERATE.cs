using System;
using CursoDesignPatterns.Strategy.Interfaces;
using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.Strategy.investment
{
    // "MODERADO", que tem 50% de chances de retornar 2.5%, e 50% de chances de retornar 0.7%;
    public class MODERATE : IInvestment
    {
        private Random random;

        public MODERATE()
        {
            random = new Random();
        }

        public double Calculates(Account account)
        {
            if (random.Next(2) == 0)
                return account.Balance * 2.5;
            else
                return account.Balance * 0.7;
        }
    }
}