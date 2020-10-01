using System;
using CursoDesignPatterns.Interfaces;
using CursoDesignPatterns.Models;
using CursoDesignPatterns.TemplateMethod;

namespace CursoDesignPatterns.Common.Impost
{
    public class IKCV : ConditionalTaxTemplate
    {

        protected override bool MustUseMaximumTaxation(Budget budget)
        {
            return budget.Value > 500 && hasItemGreaterThanHundred(budget);
        }

        protected override double MaximumTaxation(Budget budget)
        {
            return budget.Value * 0.1;
        }

        protected override double MinimumTaxation(Budget budget)
        {
            return budget.Value * 0.06;
        }

        private bool hasItemGreaterThanHundred(Budget budget)
        {
            foreach (Iten item in budget.Itens)
            {
                if (item.Price > 100) return true;
            }

            return false;
        }
    }
}