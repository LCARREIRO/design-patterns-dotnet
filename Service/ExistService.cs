using System.Linq;
using CursoDesignPatterns.Models;

namespace CursoDesignPatterns.Service
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

        public static bool ExistTwoEqualItems(Budget budget)
        {
            foreach (Iten item in budget.Itens)
            {
                if (budget.Itens.GroupBy(a => a.Name.ToLower()).Any(a => a.Count() > 1))
                    return true;
            }
            return false;
        }
    }
}