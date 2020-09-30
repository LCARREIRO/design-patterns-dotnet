using System;
using CursoDesignPatterns.Impost;
using CursoDesignPatterns.Interfaces;
using CursoDesignPatterns.investment;
using CursoDesignPatterns.Models;
using CursoDesignPatterns.Service;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Budget budget = new Budget(500.0);

            // IMPOST
            IImpost icms = new ICMS();
            IImpost iss = new ISS();
            IImpost iccc = new ICCC();

            ImpostService impostService = new ImpostService();

            // Console.WriteLine(impostService.Calculates(budget, icms));
            // Console.WriteLine(impostService.Calculates(budget, iss));
            // Console.WriteLine(impostService.Calculates(budget, iccc));

            Account account = new Account(500.0);
            
            // INVESTMENT
            IInvestment conservative = new CONSERVATIVE();
            IInvestment moderate = new MODERATE();
            IInvestment bold = new BOLD();

            InvestmentService investmentService = new InvestmentService();

            investmentService.Calculates(account, conservative);
            investmentService.Calculates(account, moderate);
            investmentService.Calculates(account, bold);
        

            Console.ReadKey();

        }
    }
}
