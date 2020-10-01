using CursoDesignPatterns.ChainOfResponsibility.Interfaces;
using CursoDesignPatterns.ChainOfResponsibility.Models;

namespace CursoDesignPatterns.ChainOfResponsibility.Discounts
{
    public class PurchaseOverFiveHundred : IDiscount
    {
        public IDiscount nextDiscount { get; set; }
        public double Discount(Budget budget)
        {
            if (budget.Value > 500.0)
                return budget.Value * 0.07;
            else
                return nextDiscount.Discount(budget);
        }
    }
}