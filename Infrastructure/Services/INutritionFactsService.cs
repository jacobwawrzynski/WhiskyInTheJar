﻿using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public interface INutritionFactsService : IRepository<NutritionFacts>
    {
    }
}
