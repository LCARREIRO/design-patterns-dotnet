namespace CursoDesignPatterns.Models
{
    public class Iten
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public Iten(string name, double price)
        {
            this.Name = name.ToUpper();
            this.Price = price;
        }
    }
}