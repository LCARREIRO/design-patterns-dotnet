using CursoDesignPatterns.ChainOfResponsibility.Enum;
using CursoDesignPatterns.Interfaces;
using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.ChainOfResponsibility.Request
{
    public class CSVFormat: IFormat
    {
        public IFormat NexFormat { get; private set; }

        public CSVFormat(IFormat nexFormat)
        {
            NexFormat = nexFormat;
        }
        public string Format(Account account, EFormat formatType)
        {
            if (formatType == EFormat.CSV)
            {
                return $"{account.Holder};{account.Balance}";
            }
            else
                return NexFormat.Format(account, formatType);
        }
    }
}