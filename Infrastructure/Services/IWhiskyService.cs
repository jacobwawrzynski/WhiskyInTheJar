using Infrastructure.Entities;
using System.Linq.Expressions;

namespace Infrastructure.Services
{
    public interface IWhiskyService : IRepository<Whisky>
    {
        IEnumerable<Whisky> SortByStarsDesc();

        // Get latest/sorting (DateAdded prop)
        // Search by name
        // Search by price
    }
}
