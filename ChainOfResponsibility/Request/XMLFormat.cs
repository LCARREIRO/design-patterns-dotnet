using CursoDesignPatterns.ChainOfResponsibility.Enum;
using CursoDesignPatterns.Interfaces;
using CursoDesignPatterns.Models;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace CursoDesignPatterns.ChainOfResponsibility.Request
{
    public class XMLFormat : IFormat
    {
        public IFormat NexFormat { get; private set; }

        public XMLFormat(IFormat nexFormat)
        {
            NexFormat = nexFormat;
        }
        public string Format(Account account, EFormat formatType)
        {
            if (formatType == EFormat.XML)
            {
                return $"<conta><titular>{account.Holder}</titular><saldo>{account.Balance}</saldo></conta>";

            }
            else
                return NexFormat.Format(account, formatType);
        }
    }
}