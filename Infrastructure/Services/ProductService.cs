using Infrastructure.DataContext;
using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class ProductService : Repository<Product>, IProductService
    {
        public ProductService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
