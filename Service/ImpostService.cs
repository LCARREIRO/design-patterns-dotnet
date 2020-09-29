using CursoDesignPatterns.Interfaces;
using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.Service
{
    public class ImpostService
    {
        public double Calculates(Budget budget, IImpost impost)
        {
            return impost.Calculates(budget);
        }
    }
}