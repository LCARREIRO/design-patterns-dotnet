using CursoDesignPatterns.Strategy.Models;

namespace CursoDesignPatterns.Strategy.Interfaces
{
    public interface IInvestment
    {
         double Calculates(Account account);
    }
}