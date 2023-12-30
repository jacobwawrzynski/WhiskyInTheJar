using Infrastructure.DataContext;
using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class ItemService : Repository<Item>, IItemService
    {
        public ItemService(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<Item> SortByStarsDesc()
        {
            return GetAll().OrderByDescending(item => item.Stars);
        }
    }
}
