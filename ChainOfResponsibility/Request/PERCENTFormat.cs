using CursoDesignPatterns.ChainOfResponsibility.Enum;
using CursoDesignPatterns.ChainOfResponsibility.Interfaces;
using CursoDesignPatterns.ChainOfResponsibility.Models;

namespace CursoDesignPatterns.ChainOfResponsibility.Request
{
    public class PERCENTFormat : IFormat
    {
         public IFormat NexFormat { get; private set; }

        public PERCENTFormat(IFormat nexFormat)
        {
            NexFormat = nexFormat;
        }

        public string Format(Account account, EFormat formatType)
        {
            if (formatType == EFormat.PERCENT)
            {
                return $"{account.Holder}%{account.Balance}";
            }
            else 
                return NexFormat.Format(account, formatType);
        }
        
    }
}