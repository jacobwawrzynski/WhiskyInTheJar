using Infrastructure.DataContext;
using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class NutritionFactsService : Repository<NutritionFacts>, INutritionFactsService
    {
        public NutritionFactsService(ApplicationDbContext context) : base(context)
        {
            
        }
    }
}
