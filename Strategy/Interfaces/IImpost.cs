using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.Strategy.Interfaces
{
    public interface IImpost
    {
        double Calculates(Budget budget);
    }
}