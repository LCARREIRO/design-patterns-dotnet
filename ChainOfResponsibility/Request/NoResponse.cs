using CursoDesignPatterns.ChainOfResponsibility.Enum;
using CursoDesignPatterns.ChainOfResponsibility.Interfaces;
using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.ChainOfResponsibility.Request
{
    public class NoResponse : IFormat
    {
        public string Format(Account account, EFormat format)
        {
            return "";
        }
    }
}