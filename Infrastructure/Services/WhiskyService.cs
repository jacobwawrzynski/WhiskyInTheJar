﻿using Infrastructure.DataContext;
using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class WhiskyService : Repository<Whisky>, IWhiskyService
    {
        public WhiskyService(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<Whisky> SortByStarsDesc()
        {
            return GetAll().OrderByDescending(item => item.Stars);
        }
    }
}