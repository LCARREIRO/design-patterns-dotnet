using CursoDesignPatterns.Models;
using CursoDesignPatterns.Strategy.Interfaces;

namespace CursoDesignPatterns.TemplateMethod
{
    public abstract class ConditionalTaxTemplate : IImpost
    {
        public double Calculates(Budget budget)
        {
            if (MustUseMaximumTaxation(budget))
            {
                return MaximumTaxation(budget);
            }
            return MinimumTaxation(budget);
        }

        public abstract bool MustUseMaximumTaxation(Budget budget);

        public abstract double MinimumTaxation(Budget budget);

        public abstract double MaximumTaxation(Budget budget);

    }
}