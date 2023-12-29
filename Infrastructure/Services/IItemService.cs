using Infrastructure.Entities;
using System.Linq.Expressions;

namespace Infrastructure.Services
{
    public interface IItemService
    {
        IEnumerable<Item> GetAllItems();
        
        // Get with X start (Stars prop)
        // Get latest/sorting (DateAdded prop)
        // Search by name
        // Search by price

        void Create(Item item);
        void Update(Item item);
        void Delete(Item item);
        Item? GetItem(int id);
        bool Save();
    }
}
