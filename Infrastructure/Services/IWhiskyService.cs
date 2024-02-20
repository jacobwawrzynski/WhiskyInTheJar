using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public interface IWhiskyService : IRepository<Whisky>
    {
        IEnumerable<Whisky> SortByRatingDesc();

        // Get latest/sorting (DateAdded prop)
        // Search by name
        // Search by price
    }
}
