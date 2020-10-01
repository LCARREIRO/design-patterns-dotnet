using System;
using System.Collections.Generic;
using CursoDesignPatterns.Models;
using CursoDesignPatterns.TemplateMethod;

namespace CursoDesignPatterns.Common.Reports
{
    public class ReportComplex : ReportTemplate
    {
        string bankInfo = "NUBANK - RUA DEZ, 2888 - 11 9999-9999";
        protected override void Head()
        {
            Console.WriteLine($"------ { bankInfo } ------");
        }

        protected override void Body(IList<Account> accounts)
        {
            foreach (var account in accounts)
            {
                Console.WriteLine($"{ account.Holder } / { account.Agency } / { account.Number } / { account.Balance } ");
            }
        }

        protected override void Footer()
        {
            Console.WriteLine($"------ banco@nubank.com / { DateTime.Now } ------");
        }
    }
}