using CursoDesignPatterns.Interfaces;
using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.Impost
{
    public class ICCC : IImpost
    {
        public double Calculates(Budget budget)
        {
            double value = budget.Value;

            if (value < 1000)
            {
                return value * 0.5;
            }
            else if (value >= 1000 && value <= 3000)
            {
                return value * 0.7;
            }
            else
            {
                return (value * 0.8) + 30;
            }
        }
    }
}