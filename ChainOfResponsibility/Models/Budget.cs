using System.Collections.Generic;

namespace CursoDesignPatterns.ChainOfResponsibility.Models
{
    public class Budget
    {
        public double Value { get; private set; }
        public IList<Iten> Itens { get; private set; }

        public Budget(double value)
        {
            this.Value = value;
            this.Itens = new List<Iten>();
        }

        public void AddIten(Iten iten)
        {
            this.Itens.Add(iten);
        }
    }
}