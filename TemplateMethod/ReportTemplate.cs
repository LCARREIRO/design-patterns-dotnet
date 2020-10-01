using System.Collections.Generic;
using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.TemplateMethod
{
    public abstract class ReportTemplate 
    {
        protected abstract void Head();
        protected abstract void Body(IList<Account> account);
        protected abstract void Footer();

        public void Print (IList<Account> account)
        {
            Head();
            Body(account);
            Footer();
        }
    }
}