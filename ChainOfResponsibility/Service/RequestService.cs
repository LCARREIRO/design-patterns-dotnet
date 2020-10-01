using System;
using CursoDesignPatterns.ChainOfResponsibility.Enum;
using CursoDesignPatterns.ChainOfResponsibility.Interfaces;
using CursoDesignPatterns.ChainOfResponsibility.Models;
using CursoDesignPatterns.ChainOfResponsibility.Request;

namespace CursoDesignPatterns.ChainOfResponsibility.Service
{
    public class RequestService
    {
        public void Format(Account account, EFormat format)
        {

            IFormat f1 = new XMLFormat(
                            new CSVFormat(
                                new PERCENTFormat(null)));

            string result = f1.Format(account, format);

            Console.Write(result);
        }
    }
}