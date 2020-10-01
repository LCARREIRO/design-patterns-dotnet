using CursoDesignPatterns.Models;
using CursoDesignPatterns.TemplateMethod;

namespace CursoDesignPatterns.Common.Impost
{
    public class ICPP : ConditionalTaxTemplate
    {
        protected override bool MustUseMaximumTaxation(Budget budget)
        {
            return budget.Value >= 500;
        }

        protected override double MaximumTaxation(Budget budget)
        {
            return budget.Value * 0.07;
        }

        protected override double MinimumTaxation(Budget budget)
        {
            return budget.Value * 0.05;
        }
    }
}