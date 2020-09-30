using CursoDesignPatterns.Strategy.Interfaces;
using CursoDesignPatterns.Strategy.Models;

namespace CursoDesignPatterns.Strategy.Impost
{
    public class ICCC : IImpost
    {
        public double Calculates(Budget budget)
        {
            double value = budget.Value;

            if (value < 1000)
            {
                return value * 0.05;
            }
            else if (value >= 1000 && value <= 3000)
            {
                return value * 0.07;
            }
            else
            {
                return (value * 0.08) + 30;
            }
        }
    }
}