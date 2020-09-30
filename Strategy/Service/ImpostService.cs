using CursoDesignPatterns.Strategy.Interfaces;
using CursoDesignPatterns.Strategy.Models;

namespace CursoDesignPatterns.Strategy.Service
{
    public class ImpostService
    {
        public double Calculates(Budget budget, IImpost impost)
        {
            return impost.Calculates(budget);
        }
    }
}