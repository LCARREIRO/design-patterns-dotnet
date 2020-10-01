using System;
using System.Collections.Generic;
using CursoDesignPatterns.Models;
using CursoDesignPatterns.TemplateMethod;

namespace CursoDesignPatterns.Common.Reports
{
    public class ReportSimple : ReportTemplate
    {
        string bankInfo = "NUBANK - 11 9999-9999";
        protected override void Head()
        {
            Console.WriteLine($"------ { bankInfo } ------");
        }

        protected override void Body(IList<Account> accounts)
        {
            foreach (var account in accounts)
            {
                Console.WriteLine($"{ account.Holder } / { account.Balance } ");
            }
        }

        protected override void Footer()
        {
            Console.WriteLine($"------ { bankInfo } ------");
        }
    }
}