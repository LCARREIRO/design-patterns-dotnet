using System;
// using CursoDesignPatterns.ChainOfResponsibility.Service;
// using CursoDesignPatterns.Models;
// using CursoDesignPatterns.ChainOfResponsibility.Enum;

using CursoDesignPatterns.Interfaces;
using CursoDesignPatterns.Strategy.investment;
using CursoDesignPatterns.Models;
using CursoDesignPatterns.Strategy.Service;
using CursoDesignPatterns.Common.Impost;
using CursoDesignPatterns.TemplateMethod;
using CursoDesignPatterns.Common.Reports;
using System.Collections.Generic;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Strategy

            // Budget budget = new Budget(100.0);
            // budget.AddIten(new Iten("TENIS", 400));

            // budget.AddIten(new Iten("TENIS", 400));
            // budget.AddIten(new Iten("SAPATO", 400));
            // budget.AddIten(new Iten("SAPATO", 400));

            // IMPOST
            // IImpost icms = new ICMS();
            // IImpost iss = new ISS();
            // IImpost iccc = new ICCC();

            // IImpost icpp = new ICPP();
            // IImpost ikcv = new IKCV();
            // IImpost ihit = new IHIT();

            // ImpostService impostService = new ImpostService();

            // Console.WriteLine(impostService.Calculates(budget, icms));
            // Console.WriteLine(impostService.Calculates(budget, iss));
            // Console.WriteLine(impostService.Calculates(budget, iccc));

            // Console.WriteLine(impostService.Calculates(budget, icpp));
            // Console.WriteLine(impostService.Calculates(budget, ihit));

            // Account account = new Account(500.0);

            // // INVESTMENT
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



            // RequestService requestService = new RequestService();
            // Account account = new Account(200, "Luciano");
            // // requestService.Format(account, EFormat.XML);
            // // requestService.Format(account, EFormat.CSV);
            // requestService.Format(account, EFormat.PERCENT);

            #endregion

            #region Template Method

            ReportSimple reportSimple = new ReportSimple();
            ReportComplex reportComplex = new ReportComplex();
            List<Account> accounts = new List<Account>();
            accounts.Add(new Account(200, "Luciano", "12", "12345"));
            accounts.Add(new Account(200, "João", "1", "12344445"));
            accounts.Add(new Account(200, "Paulo", "3", "124"));

            // reportSimple.Print(accounts);
            reportComplex.Print(accounts);

            #endregion

            Console.ReadKey();
        }
    }
}
