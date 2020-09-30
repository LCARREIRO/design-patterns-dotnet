using CursoDesignPatterns.ChainOfResponsibility.Interfaces;
using CursoDesignPatterns.ChainOfResponsibility.Model;

namespace CursoDesignPatterns.ChainOfResponsibility.Discounts
{
    public class DiscountForFiveItems : IDiscount
    {
        public IDiscount nextDiscount { get; set; }
        public double Discount(Budget budget)
        {
            if (budget.Itens.Count > 5)
                return budget.Value * 0.10;
            else
                return nextDiscount.Discount(budget);
        }
    }
}