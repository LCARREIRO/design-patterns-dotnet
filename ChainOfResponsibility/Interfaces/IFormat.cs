using CursoDesignPatterns.ChainOfResponsibility.Enum;
using CursoDesignPatterns.ChainOfResponsibility.Models;

namespace CursoDesignPatterns.ChainOfResponsibility.Interfaces
{
    public interface IFormat
    {
        string Format(Account account, EFormat format);
    }
}