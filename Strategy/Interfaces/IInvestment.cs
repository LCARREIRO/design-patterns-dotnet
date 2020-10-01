using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.Strategy.Interfaces
{
    public interface IInvestment
    {
         double Calculates(Account account);
    }
}