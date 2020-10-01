using System;
using CursoDesignPatterns.ChainOfResponsibility.Service;
using CursoDesignPatterns.Strategy.Impost;
using CursoDesignPatterns.Strategy.Interfaces;
using CursoDesignPatterns.Strategy.investment;
using CursoDesignPatterns.ChainOfResponsibility.Models;
using CursoDesignPatterns.Strategy.Service;
using CursoDesignPatterns.ChainOfResponsibility.Enum;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Strategy

            // Budget budget = new Budget(500.0);

            // IMPOST
            // IImpost icms = new ICMS();
            // IImpost iss = new ISS();
            // IImpost iccc = new ICCC();

            // ImpostService impostService = new ImpostService();

            // Console.WriteLine(impostService.Calculates(budget, icms));
            // Console.WriteLine(impostService.Calculates(budget, iss));
            // Console.WriteLine(impostService.Calculates(budget, iccc));

            // Account account = new Account(500.0);

            // INVESTMENT
            // IInvestment conservative = new CONSERVATIVE();
            // IInvestment moderate = new MODERATE();
            // IInvestment bold = new BOLD();

            // InvestmentService investmentService = new InvestmentService();

            // investmentService.Calculates(account, conservative);
            // investmentService.Calculates(account, moderate);
            // investmentService.Calculates(account, bold);

            #endregion

            #region Chain Of Responsibility

            // DiscountService discountService = new DiscountService();

            // CursoDesignPatterns.ChainOfResponsibility.Model.Budget budget = new CursoDesignPatterns.ChainOfResponsibility.Model.Budget(500);
            // budget.AddIten(new Iten("CAMISA", 250));
            // budget.AddIten(new Iten("CANETA", 250));
            // budget.AddIten(new Iten("LAPIS", 250));
            // budget.AddIten(new Iten("CALSA", 250));
            // budget.AddIten(new Iten("GRAVATA", 250));
            // budget.AddIten(new Iten("GRAVATA", 250));

            // foreach (var item in budget.Itens)
            // {
            //     Console.WriteLine($"{item.Name} - {item.Price.ToString()}");
            // }

            // discountService.Calculate(budget);

            

            RequestService requestService = new RequestService();
            Account account = new Account(200, "Luciano");
            // requestService.Format(account, EFormat.XML);
            // requestService.Format(account, EFormat.CSV);
            requestService.Format(account, EFormat.PERCENT);

            #endregion


            Console.ReadKey();
        }
    }
}
