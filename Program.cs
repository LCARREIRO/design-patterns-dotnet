using System;
using CursoDesignPatterns.Impost;
using CursoDesignPatterns.Interfaces;
using CursoDesignPatterns.Models;
using CursoDesignPatterns.Service;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // IImpost icms = new ICMS();
            // IImpost iss = new ISS();
            IImpost iccc = new ICCC();
      
            Budget budget = new Budget(500.0);

            ImpostService impostService = new ImpostService();
            // Console.WriteLine(impostService.Calculates(budget, icms));
            // Console.WriteLine(impostService.Calculates(budget, iss));
            Console.WriteLine(impostService.Calculates(budget, iccc));
            Console.ReadKey();

        }
    }
}
