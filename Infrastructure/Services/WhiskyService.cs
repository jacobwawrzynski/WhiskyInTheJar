using Infrastructure.DataContext;
using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class WhiskyService : Repository<Whisky>, IWhiskyService
    {
        public WhiskyService(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<Whisky> SortByRatingDesc()
        {
            return GetAll().OrderByDescending(whisky => whisky.Rating);
        }
    }
}
