using CursoDesignPatterns.ChainOfResponsibility.Enum;

namespace CursoDesignPatterns.ChainOfResponsibility.Models
{
    public class Request
    {
        public EFormat Format { get; private set; }
        public Request(EFormat format)
        {
            this.Format = format;
        }
    }
}