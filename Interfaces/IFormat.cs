using CursoDesignPatterns.ChainOfResponsibility.Enum;
using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.Interfaces
{
    public interface IFormat
    {
        string Format(Account account, EFormat format);
    }
}