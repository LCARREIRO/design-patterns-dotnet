using CursoDesignPatterns.Models;
using CursoDesignPatterns.TemplateMethod;

namespace CursoDesignPatterns.Common.Impost
{
    public class ICPP : ConditionalTaxTemplate
    {
        public override bool MustUseMaximumTaxation(Budget budget)
        {
            return budget.Value >= 500;
        }

        public override double MaximumTaxation(Budget budget)
        {
            return budget.Value * 0.07;
        }

        public override double MinimumTaxation(Budget budget)
        {
            return budget.Value * 0.05;
        }
    }
}