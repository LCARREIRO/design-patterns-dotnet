using CursoDesignPatterns.ChainOfResponsibility.Enum;
using CursoDesignPatterns.ChainOfResponsibility.Interfaces;
using CursoDesignPatterns.Models;
using CursoDesignPatterns.ChainOfResponsibility.Service;

namespace CursoDesignPatterns.ChainOfResponsibility.Discounts
{
    public class MarriedSale : IDiscount
    {
        public IDiscount nextDiscount { get; set; }

        public double Discount(Budget budget)
        {
            if (ExistService.Exist(EIten.CANETA.ToString(), budget) && ExistService.Exist(EIten.LAPIS.ToString(), budget))
                return budget.Value * 0.05;
            else
                return nextDiscount.Discount(budget);
        }
    }
}