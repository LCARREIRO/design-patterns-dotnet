using CursoDesignPatterns.Models;
using CursoDesignPatterns.Interfaces;

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

        protected abstract bool MustUseMaximumTaxation(Budget budget);

        protected abstract double MinimumTaxation(Budget budget);

        protected abstract double MaximumTaxation(Budget budget);

    }
}