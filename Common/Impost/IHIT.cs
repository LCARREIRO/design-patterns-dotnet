using System;
using CursoDesignPatterns.Models;
using CursoDesignPatterns.Service;
using CursoDesignPatterns.TemplateMethod;

namespace CursoDesignPatterns.Common.Impost
{
    public class IHIT : ConditionalTaxTemplate
    {

        // Caso existam 2 ítens com o mesmo nome, o imposto deve ser de 13% mais R$100,00.
        // Caso contrário, o valor do imposto deverá ser (1% * o número de ítens no orçamento).

        protected override bool MustUseMaximumTaxation(Budget budget)
        {
            return hasTwoItemsWithTheSameName(budget);
        }

        private bool hasTwoItemsWithTheSameName(Budget budget)
        {
            return ExistService.ExistTwoEqualItems(budget);
        }

        protected override double MaximumTaxation(Budget budget)
        {
            return  (budget.Value * 0.13) + 100;
        }

        protected override double MinimumTaxation(Budget budget)
        {
            return (budget.Value * 0.01) * budget.Itens.Count;
        }
    }
}