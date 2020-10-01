using CursoDesignPatterns.ChainOfResponsibility.Models;

namespace CursoDesignPatterns.ChainOfResponsibility.Service
{
    public static class ExistService
    {
        public static bool Exist(string itemName, Budget budget)
        {
            foreach (Iten item in budget.Itens)
            {
                if (item.Name.Equals(itemName.ToUpper()))
                    return true;
            }
            return false;
        }
    }
}