using CursoDesignPatterns.ChainOfResponsibility.Models;

namespace CursoDesignPatterns.ChainOfResponsibility.Interfaces
{
    public interface IDiscount
    {
        double Discount(Budget budget);
        IDiscount nextDiscount { get; set; }
    }
}