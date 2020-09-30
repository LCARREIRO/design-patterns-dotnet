
using System;
using CursoDesignPatterns.ChainOfResponsibility.Discounts;
using CursoDesignPatterns.ChainOfResponsibility.Interfaces;
using CursoDesignPatterns.ChainOfResponsibility.Model;

namespace CursoDesignPatterns.ChainOfResponsibility.Service
{
    public class DiscountService
    {
        public void Calculate(Budget budget)
        {
            IDiscount d1 = new DiscountForFiveItems();
            IDiscount d2 = new PurchaseOverFiveHundred();
            IDiscount d3 = new DiscountMarriedSale();
            IDiscount d4 = new NoDiscount();  

            d1.nextDiscount = d2;
            d2.nextDiscount = d3;
            d3.nextDiscount = d4;

            double value =  d1.nextDiscount.Discount(budget);

            Console.WriteLine(value);
        }
    }
}