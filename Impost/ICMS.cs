using System;
using CursoDesignPatterns.Interfaces;
using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.Impost
{
    public class ICMS : IImpost
    {
        public double Calculates(Budget budget)
        {
            return budget.Value * 0.5;
        }
    }
}