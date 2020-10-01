using CursoDesignPatterns.Strategy.Interfaces;
using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.Commom.Impost
{
    public class ISS : IImpost
    {
        public double Calculates(Budget budget)
        {
            return budget.Value * 0.06;
        }
    }
}