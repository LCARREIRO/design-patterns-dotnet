using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.Interfaces
{
    public interface IDiscount
    {
        double Discount(Budget budget);
        IDiscount nextDiscount { get; set; }
    }
}