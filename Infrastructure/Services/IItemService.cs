using Infrastructure.Entities;
using System.Linq.Expressions;

namespace Infrastructure.Services
{
    public interface IItemService : IRepository<Item>
    {
        IEnumerable<Item> SortByStarsDesc();

        // Get latest/sorting (DateAdded prop)
        // Search by name
        // Search by price
    }
}
