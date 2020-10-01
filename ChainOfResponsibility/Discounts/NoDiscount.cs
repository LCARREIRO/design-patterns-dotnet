using CursoDesignPatterns.ChainOfResponsibility.Interfaces;
using CursoDesignPatterns.ChainOfResponsibility.Models;

namespace CursoDesignPatterns.ChainOfResponsibility.Discounts
{
    public class NoDiscount : IDiscount
    {
        public IDiscount nextDiscount { get ; set; }
        public double Discount(Budget budget)
        {
            return 0;
        }
    }
}