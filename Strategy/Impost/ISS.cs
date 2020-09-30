using CursoDesignPatterns.Strategy.Interfaces;
using CursoDesignPatterns.Strategy.Models;

namespace CursoDesignPatterns.Strategy.Impost
{
    public class ISS : IImpost
    {
        public double Calculates(Budget budget)
        {
            return budget.Value * 0.06;
        }
    }
}